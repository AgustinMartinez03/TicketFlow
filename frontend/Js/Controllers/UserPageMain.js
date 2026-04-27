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
                console.log("Así viene la butaca desde C#:", seatsList[0]);
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
    // 1. Agrupar butacas por Fila (ahora usamos rowIdentifier)
    const rows = {};
    seatsList.forEach(seat => {
        if (!rows[seat.rowIdentifier]) rows[seat.rowIdentifier] = [];
        rows[seat.rowIdentifier].push(seat);
    });

    let html = '';

    // 2. Ordenar las filas alfabéticamente (A, B, C...) y dibujarlas
    Object.keys(rows).sort().forEach(rowKey => {
        const seatsInRow = rows[rowKey];
        
        // Ordenar butacas numéricamente (ahora usamos seatNumber)
        seatsInRow.sort((a, b) => a.seatNumber - b.seatNumber);

        html += `
            <div class="d-flex align-items-center mb-2">
                <div style="width: 25px; font-weight: bold; color: var(--text-muted); font-size: 0.9rem;">${rowKey}</div>
                <div class="d-flex gap-2 flex-wrap flex-grow-1 justify-content-center">
        `;

        // 3. Dibujar cada butaca de esta fila
        seatsInRow.forEach(seat => {
            let bgColor = '';
            let borderColor = '';
            let disabledClass = '';
            let cursorStyle = 'cursor: pointer;';

            // Evaluamos el Status que manda el backend
            if (seat.status === 'Available') {
                bgColor = 'rgba(16, 185, 129, 0.15)'; // Verde oscuro
                borderColor = 'rgba(16, 185, 129, 0.5)';
            } else if (seat.status === 'Reserved') {
                bgColor = 'rgba(245, 158, 11, 0.15)'; // Amarillo oscuro
                borderColor = 'rgba(245, 158, 11, 0.5)';
                disabledClass = 'disabled';
                cursorStyle = 'cursor: not-allowed; opacity: 0.8;';
            } else {
                // Sold (Vendido)
                bgColor = 'rgba(255, 255, 255, 0.05)'; // Gris
                borderColor = 'rgba(255, 255, 255, 0.1)';
                disabledClass = 'disabled';
                cursorStyle = 'cursor: not-allowed; opacity: 0.5;';
            }

            // Actualizamos data-seat-row y data-seat-number
            html += `
                <button class="btn btn-sm seat-btn ${disabledClass}"
                        style="width: 32px; height: 32px; padding: 0; font-size: 0.75rem; border-radius: 6px; 
                               background-color: ${bgColor}; border: 1px solid ${borderColor}; color: #fff; ${cursorStyle}"
                        data-seat-id="${seat.id}"
                        data-seat-row="${seat.rowIdentifier}"
                        data-seat-number="${seat.seatNumber}"
                        title="Fila ${seat.rowIdentifier} - Butaca ${seat.seatNumber}">
                    ${seat.seatNumber}
                </button>
            `;
        });

        html += `
                </div>
                <div style="width: 25px; text-align: right; font-weight: bold; color: var(--text-muted); font-size: 0.9rem;">${rowKey}</div>
            </div>
        `;
    });

    seatsGrid.innerHTML = html;

    // 4. Activar los clics solo en las disponibles
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
                        seatBtn.classList.add('disabled');

                        // Le cambiamos los estilos al color "Reservado" (Amarillo oscuro)
                        seatBtn.style.backgroundColor = 'rgba(245, 158, 11, 0.15)'; 
                        seatBtn.style.borderColor = 'rgba(245, 158, 11, 0.5)';
                        seatBtn.style.cursor = 'not-allowed';
                        seatBtn.style.opacity = '0.8';

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