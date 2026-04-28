import { fetchEvents } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';
import { fetchSeatsBySector, reserveSeatApi } from '../Services/SeatService.js';

// Variables globales para las Vistas
const viewCatalog = document.getElementById('view-catalog');
const viewSectors = document.getElementById('view-sectors');
const sectorsGrid = document.getElementById('sectors-grid');
const viewSeats = document.getElementById('view-seats');
const seatsGrid = document.getElementById('seats-grid');
const seatMapTitle = document.getElementById('seat-map-title');

async function initPage() {
    const gridContainer = document.getElementById('events-grid');
    
    try {
        // 1. Pedir los datos a la API y guardarlos en "responseData"
        const responseData = await fetchEvents();
        
        // Extraer el array real mirando la propiedad "events" de tu JSON
        const eventsList = responseData.events ? responseData.events : responseData; 

        // 2. Limpiar el spinner de carga
        gridContainer.innerHTML = ''; 

        // 3. ¿No hay eventos?
        if (!eventsList || eventsList.length === 0) {
            gridContainer.innerHTML = '<div class="col-12 text-center text-muted">No hay eventos disponibles.</div>';
            return;
        }

        // 4. Transformar los datos en HTML y pegarlos en la grilla
        let cardsHtml = '';
        eventsList.forEach(event => {
            cardsHtml += createEventCard(event);
        });
        gridContainer.innerHTML = cardsHtml;

        // 5. Escuchar los clics en los botones
        attachButtonEvents();

    } catch (error) {
        console.error("Error real capturado:", error);
        gridContainer.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar el catálogo.</div>';
    }
}

// Actualizamos la función que escucha los clics
function attachButtonEvents() {
    const buttons = document.querySelectorAll('.btn-select-seats');
    
    buttons.forEach(button => {
        button.addEventListener('click', async (e) => {
            const eventId = e.target.getAttribute('data-id');
            
            // 1. Ocultar catálogo, mostrar sectores
            viewCatalog.classList.add('d-none'); // Desaparece
            viewSectors.classList.remove('d-none'); // Aparece
            
            // 2. Poner un mensaje de carga
            sectorsGrid.innerHTML = '<div class="col-12 text-center"><div class="spinner-border text-light" role="status"></div></div>';
            
            // 3. Traer los sectores de la API
            try {
                const responseData = await fetchSectorsByEvent(eventId);
                const sectorsList = responseData.sectors ? responseData.sectors : responseData;
                
                // Limpiamos el spinner
                sectorsGrid.innerHTML = '';

                // ¿El evento no tiene sectores cargados en la BD?
                if (!sectorsList || sectorsList.length === 0) {
                    sectorsGrid.innerHTML = '<div class="col-12 text-center text-muted">No hay sectores disponibles para este evento.</div>';
                    return;
                }

                // Generamos el HTML de todas las tarjetas
                let sectorsHtml = '';
                sectorsList.forEach(sector => {
                    sectorsHtml += createSectorCard(sector);
                });
                sectorsGrid.innerHTML = sectorsHtml;

                // 4. Activar los botones nuevos de "Ver Butacas"
                attachSectorButtonEvents();

            } catch (error) {
                console.error(error);
                sectorsGrid.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar sectores.</div>';
            }
        });
    });
}

// Configurar el botón de volver
document.getElementById('btn-back-catalog').addEventListener('click', () => {
    viewSectors.classList.add('d-none');
    viewCatalog.classList.remove('d-none');
});

function attachSectorButtonEvents() {
    const btnViewSeats = document.querySelectorAll('.btn-view-seats');

    btnViewSeats.forEach(button => {
        button.addEventListener('click', async (e) => {
            const sectorId = e.target.getAttribute('data-sector-id');

            // ¡Truco limpio! Leemos el nombre directamente del botón
            const sectorName = e.target.getAttribute('data-name');
            seatMapTitle.innerText = `Sector: ${sectorName}`;

            // 1. Ocultar vista Sectores, mostrar vista Butacas
            viewSectors.classList.add('d-none');
            viewSeats.classList.remove('d-none');

            // 2. Spinner
            seatsGrid.innerHTML = '<div class="text-center my-5"><div class="spinner-border" style="color: var(--neon-purple);" role="status"></div><p class="mt-2 text-muted">Armando el escenario...</p></div>';

            // 3. Traer los datos
            try {
                const responseData = await fetchSeatsBySector(sectorId);
                const seatsList = responseData.seats ? responseData.seats : responseData;
                
                if (!seatsList || seatsList.length === 0) {
                    seatsGrid.innerHTML = '<div class="text-center text-muted py-4">No hay butacas configuradas para este sector.</div>';
                    return;
                }
                
                // 4. Mandar a dibujar la grilla
                renderSeatsGrid(seatsList);

            } catch (error) {
                console.error(error);
                seatsGrid.innerHTML = '<div class="text-center text-danger py-4">Error al cargar el mapa de butacas.</div>';
            }
        });
    });
}

// Función que procesa la lista y dibuja el mapa
// Función que procesa la lista y dibuja el mapa (ACTUALIZADA)
function renderSeatsGrid(seatsList) {
    const rows = {};
    seatsList.forEach(seat => {
        if (!rows[seat.rowIdentifier]) rows[seat.rowIdentifier] = [];
        rows[seat.rowIdentifier].push(seat);
    });

    let html = '';

    Object.keys(rows).sort().forEach(rowKey => {
        const seatsInRow = rows[rowKey];
        seatsInRow.sort((a, b) => a.seatNumber - b.seatNumber);

        // Usamos la nueva clase .row-label
        html += `
            <div class="d-flex align-items-center mb-2">
                <div class="row-label">${rowKey}</div>
                <div class="d-flex gap-2 flex-wrap flex-grow-1 justify-content-center">
        `;

        seatsInRow.forEach(seat => {
            let statusClass = '';
            let disabledClass = '';

            // Evaluamos el Status usando solo clases CSS
            if (seat.status === 'Available') {
                statusClass = 'seat-available';
            } else if (seat.status === 'Reserved') {
                statusClass = 'seat-reserved';
                disabledClass = 'disabled';
            } else {
                statusClass = 'seat-sold';
                disabledClass = 'disabled';
            }

            // HTML limpito, sin atributos style
            html += `
                <button class="btn btn-sm seat-btn ${statusClass} ${disabledClass}"
                        data-seat-id="${seat.id}"
                        data-seat-row="${seat.rowIdentifier}"
                        data-seat-number="${seat.seatNumber}"
                        title="Fila ${seat.rowIdentifier} - Butaca ${seat.seatNumber}">
                    ${seat.seatNumber}
                </button>
            `;
        });

        // Usamos la nueva clase .row-label para el lado derecho
        html += `
                </div>
                <div class="row-label text-end">${rowKey}</div>
            </div>
        `;
    });

    seatsGrid.innerHTML = html;
    attachSeatClickEvents();
}

// Escuchar clics en butacas disponibles (CON SWEETALERT2)
function attachSeatClickEvents() {
    const availableSeats = document.querySelectorAll('.seat-btn:not(.disabled)');
    
    availableSeats.forEach(seatBtn => {
        seatBtn.addEventListener('click', (e) => {
            const seatId = e.target.getAttribute('data-seat-id');
            const row = e.target.getAttribute('data-seat-row');
            const number = e.target.getAttribute('data-seat-number');

            // Lanzamos el cartel de SweetAlert2 con estilos oscuros
            Swal.fire({
                title: '¿Confirmar Reserva?',
                text: `Estás por seleccionar la Fila ${row}, Butaca ${number}. ¿Deseas continuar?`,
                icon: 'question',
                showCancelButton: true,
                confirmButtonColor: '#8b5cf6', // Nuestro violeta neón
                cancelButtonColor: '#3f3f46',  // Gris oscuro
                confirmButtonText: 'Sí, reservar',
                cancelButtonText: 'Cancelar',
                background: '#1a1d24',         // Fondo oscuro de la tarjeta
                color: '#ffffff'               // Texto blanco
            }).then(async(result) => {
                
                // Si el usuario hace clic en "Sí, reservar"
                if (result.isConfirmed) {
                    
                    // Mostramos un cartel de "Cargando..." para que el usuario no haga doble clic
                    Swal.fire({
                        title: 'Procesando reserva...',
                        text: 'Por favor aguardá un instante.',
                        background: '#1a1d24',
                        color: '#ffffff',
                        allowOutsideClick: false,
                        didOpen: () => {
                            Swal.showLoading();
                        }
                    });

                    try {
                        // ID de prueba (Reemplazar por el Guid de tu C# en SQL Server)
                        const dummyUserId = "1"; // <--- OJO AQUÍ
                        
                        // 1. Llamamos a la API!
                        await reserveSeatApi(seatId, dummyUserId);
                        
                        // 2. MAGIA DE FRONTEND: Actualizamos el botón instantáneamente en la pantalla
                        // Le agregamos la clase disabled para que no dispare más clics
                        // AHORA (Usar esto):
                        // 2. MAGIA DE FRONTEND: Actualizamos el botón instantáneamente cambiando clases
                        seatBtn.classList.remove('seat-available');
                        seatBtn.classList.add('disabled', 'seat-reserved');

                        // 2. Si salió bien, mostramos cartel de éxito
                        await Swal.fire({
                            title: '¡Reserva Confirmada!',
                            text: `Tu butaca ha sido reservada con éxito.`,
                            icon: 'success',
                            background: '#1a1d24',
                            color: '#ffffff',
                            confirmButtonColor: '#10b981' // Verde éxito
                        });

                        // 3. (Opcional pero recomendado) Recargar el mapa de butacas para que se pinte de gris (Vendida)
                        // Para hacerlo, simulamos un clic en el botón "Ver Butacas" del sector actual
                        // const currentSectorBtn = document.querySelector(`.btn-view-seats[data-sector-id="${e.target.closest('#seats-grid').getAttribute('data-current-sector') || ''}"]`);
                        // if(currentSectorBtn) currentSectorBtn.click(); // Esto recargaría la vista

                    } catch (error) {
                        // Si salió mal (ej: alguien más la compró un segundo antes)
                        Swal.fire({
                            title: '¡Ups!',
                            text: error.message || 'No se pudo completar la reserva.',
                            icon: 'error',
                            background: '#1a1d24',
                            color: '#ffffff',
                            confirmButtonColor: '#ef4444' // Rojo error
                        });
                    }
                }
            });
        });
    });
}

// Botón para volver atrás (De Vista 3 a Vista 2)
document.getElementById('btn-back-sectors').addEventListener('click', () => {
    viewSeats.classList.add('d-none');
    viewSectors.classList.remove('d-none');
});

// Arrancar
initPage();