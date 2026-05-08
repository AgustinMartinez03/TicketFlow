import { getUserIdFromToken, logout } from '../Services/AuthService.js';
import { fetchEvents, createEventApi } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';
import { fetchSeatsBySector, reserveSeatApi } from '../Services/SeatService.js';
import { processPaymentApi } from '../Services/PaymentService.js';
import { getMiReserva, setMiReserva, clearMiReserva } from '../Services/ReservationStorage.js';
import { iniciarCarritoConTemporizador, detenerTemporizador } from './CartController.js';
import { createSeatsGridHtml } from '../Components/SeatsComponent.js';

const viewCatalog = document.getElementById('view-catalog');
const viewSectors = document.getElementById('view-sectors');
const sectorsGrid = document.getElementById('sectors-grid');
const viewSeats = document.getElementById('view-seats');
const seatsGrid = document.getElementById('seats-grid');
const seatMapTitle = document.getElementById('seat-map-title');
const viewCreateEvent = document.getElementById('view-create-event');
const adminControls = document.getElementById('admin-controls');
const sectorsContainer = document.getElementById('sectors-container');

async function initPage() {
    const userName = sessionStorage.getItem('user_name');
    const nameDisplay = document.getElementById('user-name-display');
    
    if (userName && nameDisplay) {
        nameDisplay.innerText = `Usuario: ${userName}`;
    }

    const userRole = sessionStorage.getItem('user_role');
    if (userRole === 'Admin') {
        adminControls.classList.remove('d-none');
    }
    const gridContainer = document.getElementById('events-grid');
    
    try {
        const responseData = await fetchEvents();
        
        const eventsList = responseData.events ? responseData.events : responseData; 

        gridContainer.innerHTML = ''; 

        if (!eventsList || eventsList.length === 0) {
            gridContainer.innerHTML = '<div class="col-12 text-center text-muted">No hay eventos disponibles.</div>';
            return;
        }

        let cardsHtml = '';
        eventsList.forEach(event => {
            cardsHtml += createEventCard(event);
        });
        gridContainer.innerHTML = cardsHtml;

        attachButtonEvents();

    } catch (error) {
        console.error("Error real capturado:", error);
        gridContainer.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar el catálogo.</div>';
    }
}

function attachButtonEvents() {
    const buttons = document.querySelectorAll('.btn-select-seats');
    
    buttons.forEach(button => {
        button.addEventListener('click', async (e) => {
            const eventId = e.target.getAttribute('data-id');
            
            viewCatalog.classList.add('d-none');
            viewSectors.classList.remove('d-none');
            
            sectorsGrid.innerHTML = '<div class="col-12 text-center"><div class="spinner-border text-light" role="status"></div></div>';
            
            try {
                const responseData = await fetchSectorsByEvent(eventId);
                const sectorsList = responseData.sectors ? responseData.sectors : responseData;
                
                sectorsGrid.innerHTML = '';

                if (!sectorsList || sectorsList.length === 0) {
                    sectorsGrid.innerHTML = '<div class="col-12 text-center text-muted">No hay sectores disponibles para este evento.</div>';
                    return;
                }

                let sectorsHtml = '';
                sectorsList.forEach(sector => {
                    sectorsHtml += createSectorCard(sector);
                });
                sectorsGrid.innerHTML = sectorsHtml;

                attachSectorButtonEvents();

            } catch (error) {
                console.error(error);
                sectorsGrid.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar sectores.</div>';
            }
        });
    });
}

document.getElementById('btn-back-catalog').addEventListener('click', () => {
    viewSectors.classList.add('d-none');
    viewCatalog.classList.remove('d-none');
});

function attachSectorButtonEvents() {
    const btnViewSeats = document.querySelectorAll('.btn-view-seats');

    btnViewSeats.forEach(button => {
        button.addEventListener('click', async (e) => {
            const sectorId = e.target.getAttribute('data-sector-id');

            const sectorName = e.target.getAttribute('data-name');
            seatMapTitle.innerText = `Sector: ${sectorName}`;

            viewSectors.classList.add('d-none');
            viewSeats.classList.remove('d-none');

            seatsGrid.innerHTML = '<div class="text-center my-5"><div class="spinner-border" style="color: var(--neon-purple);" role="status"></div><p class="mt-2 text-muted">Armando el escenario...</p></div>';

            try {
                const responseData = await fetchSeatsBySector(sectorId);
                const seatsList = responseData.seats ? responseData.seats : responseData;
                
                if (!seatsList || seatsList.length === 0) {
                    seatsGrid.innerHTML = '<div class="text-center text-muted py-4">No hay butacas configuradas para este sector.</div>';
                    return;
                }
                
                renderSeatsGrid(seatsList);

            } catch (error) {
                console.error(error);
                seatsGrid.innerHTML = '<div class="text-center text-danger py-4">Error al cargar el mapa de butacas.</div>';
            }
        });
    });
}

// ... (arriba de esto queda igual hasta attachSectorButtonEvents) ...

// 👇 1. VARIABLES DE ESTADO Y MANEJO DE SESSION STORAGE
// 👇 Leemos el ID del token
const CURRENT_USER_ID = getUserIdFromToken();

// 👇 Si no hay usuario logueado, lo pateamos al login
if (!CURRENT_USER_ID) {
    window.location.href = 'Pages/login.html';
}

// 👇 2. TEMPORIZADOR A PRUEBA DE F5 Y WORKER DEL BACKEND

// Función auxiliar para recargar la grilla
async function recargarGrillaButacas(sectorId) {
    try {
        const responseData = await fetchSeatsBySector(sectorId);
        const seatsList = responseData.seats ? responseData.seats : responseData;
        renderSeatsGrid(seatsList, sectorId);
    } catch (error) {
        console.error("Error al recargar grilla:", error);
    }
}

// 👇 3. RENDERIZADO INTELIGENTE (VERIFICA MEMORIA AL INICIAR)
function renderSeatsGrid(seatsList, sectorId) { 
    // Verificamos si hay una reserva activa en memoria y si sigue viva
    const miReserva = getMiReserva();
    if (miReserva) {
        if (miReserva.expiresAt > Date.now()) {
            iniciarCarritoConTemporizador(miReserva.reservationId, sectorId, miReserva.expiresAt);
        } else {
            clearMiReserva(); 
        }
    } else {
        detenerTemporizador();
    }

    const reservaActiva = getMiReserva(); // Volvemos a leer por si la borramos arriba

    // 👇 REFACTOR: Delegamos el armado del HTML al componente visual
    seatsGrid.innerHTML = createSeatsGridHtml(seatsList, sectorId, reservaActiva);
    
    attachSeatClickEvents();
}


// 👇 4. LÓGICA DE CLIC (CON BLOQUEO DE MULTIPLES RESERVAS Y FIX DEL SWEETALERT)
function attachSeatClickEvents() {
    const clickableSeats = document.querySelectorAll('.seat-btn:not(.disabled)');
    
    clickableSeats.forEach(seatBtn => {
        seatBtn.replaceWith(seatBtn.cloneNode(true));
    });

    const newClickableSeats = document.querySelectorAll('.seat-btn:not(.disabled)');

    newClickableSeats.forEach(seatBtn => {
        seatBtn.addEventListener('click', async (e) => {
            
            const seatId = e.target.getAttribute('data-seat-id');
            const row = e.target.getAttribute('data-seat-row');
            const number = e.target.getAttribute('data-seat-number');
            const sectorId = e.target.getAttribute('data-sector-id'); 

            const miReservaActual = getMiReserva();

            // -- ESCENARIO A: PAGO DE BUTACA NARANJA --
            if (seatBtn.classList.contains('seat-my-reserved') && miReservaActual) {
                const { value: formValues } = await Swal.fire({
                    title: 'Pagar Reserva',
                    html: `
                        <p class="text-light mb-3">Estás a punto de pagar la Fila ${row}, Butaca ${number}.</p>
                        <input id="swal-input1" class="swal2-input bg-dark text-light border-secondary" placeholder="Número de Tarjeta (Simulado)">
                    `,
                    focusConfirm: false,
                    showCancelButton: true,
                    confirmButtonText: 'Procesar Pago',
                    cancelButtonText: 'Cancelar',
                    background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#10b981',
                    preConfirm: () => {
                        return document.getElementById('swal-input1').value;
                    }
                });

                if (formValues) {
                    try {
                        Swal.fire({
                            title: 'Procesando pago...',
                            background: '#1a1d24', color: '#ffffff',
                            allowOutsideClick: false,
                            didOpen: () => { Swal.showLoading(); }
                        });

                        // 👇 REFACTOR: Usamos el servicio en lugar del fetch manual
                        await processPaymentApi(miReservaActual.reservationId, formValues);

                        // Éxito
                        detenerTemporizador();
                        clearMiReserva();

                        seatBtn.classList.remove('seat-my-reserved');
                        seatBtn.classList.add('seat-sold', 'disabled');

                        Swal.fire({
                            title: '¡Pago Exitoso!',
                            text: 'Disfruta tu evento.',
                            icon: 'success',
                            background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#10b981'
                        });

                    } catch (error) {
                        // Fix del colgado: Este Swal pisa al de "Procesando pago..."
                        Swal.fire({ 
                            title: 'Error', 
                            text: error.message || 'El pago no pudo procesarse.', 
                            icon: 'error', 
                            background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'
                        });
                    }
                }
                return; 
            }

            // -- ESCENARIO B: RESERVAR BUTACA VERDE --
            if (seatBtn.classList.contains('seat-available')) {
                
                // REGLA DE NEGOCIO: Bloqueamos si ya tiene una reserva pendiente
                if (miReservaActual) {
                    Swal.fire({
                        title: 'Reserva en curso',
                        text: 'Ya tienes una butaca pendiente de pago. Por favor, finaliza esa compra o espera a que expire.',
                        icon: 'info',
                        background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#8b5cf6'
                    });
                    return; // Cortamos acá
                }

                Swal.fire({
                    title: '¿Confirmar Reserva?',
                    text: `Estás por seleccionar la Fila ${row}, Butaca ${number}. ¿Deseas continuar?`,
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: '#8b5cf6', cancelButtonColor: '#3f3f46',
                    confirmButtonText: 'Sí, reservar', cancelButtonText: 'Cancelar',
                    background: '#1a1d24', color: '#ffffff'
                }).then(async(result) => {
                    if (result.isConfirmed) {
                        Swal.fire({
                            title: 'Procesando reserva...',
                            background: '#1a1d24', color: '#ffffff',
                            allowOutsideClick: false,
                            didOpen: () => { Swal.showLoading(); }
                        });

                        try {
                            const responseData = await reserveSeatApi(seatId, CURRENT_USER_ID);
                            
                            // Creamos la reserva con Timestamp exacto: Ahora + 5 minutos
                            const timestampExpiracion = Date.now() + (5 * 60 * 1000);
                            
                            const nuevaReserva = { 
                                seatId: seatId, 
                                reservationId: responseData.reservationId,
                                expiresAt: timestampExpiracion 
                            };
                            
                            setMiReserva(nuevaReserva);
                            
                            iniciarCarritoConTemporizador(responseData.reservationId, sectorId, timestampExpiracion);

                            seatBtn.classList.remove('seat-available');
                            seatBtn.classList.add('seat-my-reserved');

                            Swal.fire({
                                title: '¡Reserva Confirmada!',
                                text: `Tu butaca ha sido reservada con éxito. Tienes 5 minutos para pagar.`,
                                icon: 'success',
                                background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#10b981'
                            });

                        } catch (error) {
                            if (error.status === 409) {
                                seatBtn.classList.remove('seat-available');
                                seatBtn.classList.add('seat-reserved', 'disabled');

                                Swal.fire({
                                    title: '¡Asiento no disponible!',
                                    text: 'Otro usuario ganó esta butaca milisegundos antes. Por favor elige otra.',
                                    icon: 'warning',
                                    background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'
                                });
                            } else {
                                Swal.fire({
                                    title: '¡Ups!',
                                    text: error.message || 'No se pudo completar la reserva.',
                                    icon: 'error',
                                    background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'
                                });
                            }
                        }
                    }
                });
            }
        });
    });
}

// Abrir panel admin
document.getElementById('btn-nav-create-event').addEventListener('click', () => {
    viewCatalog.classList.add('d-none');
    viewCreateEvent.classList.remove('d-none');
    
    // Si no hay ningún sector en pantalla, agregamos uno por defecto
    if (sectorsContainer.children.length === 0) {
        agregarFilaSector();
    }
});

// Volver al catálogo desde admin
document.getElementById('btn-back-catalog-from-admin').addEventListener('click', () => {
    viewCreateEvent.classList.add('d-none');
    viewCatalog.classList.remove('d-none');
});

document.getElementById('btn-back-sectors').addEventListener('click', () => {
    viewSeats.classList.add('d-none');
    viewSectors.classList.remove('d-none');
});

// 👇 FUNCIONES PARA EL PANEL ADMIN
function agregarFilaSector() {
    const sectorId = Date.now(); // ID único temporal
    
    const html = `
        <div class="row g-2 mb-3 sector-entry" id="sector-row-${sectorId}">
            <div class="col-md-5">
                <input type="text" class="form-control text-white sector-name" style="background-color: #1f2937; border: none;" placeholder="Nombre (ej: VIP)" required>
            </div>
            <div class="col-md-3 mt-2 mt-md-0">
                <input type="number" class="form-control text-white sector-price" style="background-color: #1f2937; border: none;" placeholder="Precio $" min="1" required>
            </div>
            <div class="col-md-3 mt-2 mt-md-0">
                <input type="number" class="form-control text-white sector-capacity" style="background-color: #1f2937; border: none;" placeholder="Capacidad" min="1" max="100" required>
            </div>
            <div class="col-md-1 mt-2 mt-md-0 d-flex align-items-end">
                <button type="button" class="btn btn-outline-danger w-100" onclick="document.getElementById('sector-row-${sectorId}').remove()" title="Eliminar Sector">
                    X
                </button>
            </div>
        </div>
    `;
    
    sectorsContainer.insertAdjacentHTML('beforeend', html);
}

document.getElementById('btn-add-sector').addEventListener('click', agregarFilaSector);

// 👇 EVENTO PARA CREAR EL EVENTO Y SUS SECTORES
document.getElementById('form-create-event').addEventListener('submit', async (e) => {
    e.preventDefault(); // Evita que la página recargue

    // 1. Capturamos los datos básicos
    const name = document.getElementById('event-name').value;
    const venue = document.getElementById('event-venue').value;
    const dateInput = document.getElementById('event-date').value;

    // Convertimos la fecha local al formato universal (ISO) que exige el Backend
    const formattedDate = new Date(dateInput).toISOString();

    // 2. Armamos la lista dinámica de sectores
    const sectorsArray = [];
    const sectorEntries = document.querySelectorAll('.sector-entry');

    if (sectorEntries.length === 0) {
        Swal.fire({ icon: 'warning', title: 'Atención', text: 'Debes agregar al menos un sector.', background: '#1a1d24', color: '#ffffff' });
        return;
    }

    // Recorremos cada fila de sector que haya en la pantalla
    sectorEntries.forEach(entry => {
        const sName = entry.querySelector('.sector-name').value;
        const sPrice = parseFloat(entry.querySelector('.sector-price').value); // Convertir a número decimal
        const sCapacity = parseInt(entry.querySelector('.sector-capacity').value); // Convertir a número entero

        sectorsArray.push({
            name: sName,
            price: sPrice,
            capacity: sCapacity
        });
    });

    // 3. Armamos el JSON final idéntico al que pide Swagger
    const newEventData = {
        name: name,
        venue: venue,
        date: formattedDate,
        sectors: sectorsArray
    };

    // 4. Lo enviamos al Backend
    try {
        Swal.fire({
            title: 'Creando Evento...',
            text: 'Generando recinto y butacas en la base de datos.',
            background: '#1a1d24', color: '#ffffff',
            allowOutsideClick: false,
            didOpen: () => { Swal.showLoading(); }
        });

        await createEventApi(newEventData);

        // Si salió bien...
        Swal.fire({
            icon: 'success',
            title: '¡Evento Creado!',
            text: 'El evento está listo para recibir reservas.',
            background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#10b981'
        });

        // Limpiamos el formulario
        document.getElementById('form-create-event').reset();
        document.getElementById('sectors-container').innerHTML = '';
        
        // Volvemos al catálogo principal
        document.getElementById('btn-back-catalog-from-admin').click();
        
        // Recargamos los eventos para que el nuevo aparezca instantáneamente
        initPage();

    } catch (error) {
        Swal.fire({
            icon: 'error',
            title: 'Error de creación',
            text: error.message,
            background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'
        });
    }
});

// Al final de UserPageMain.js
document.getElementById('btn-logout').addEventListener('click', () => {
    logout(); // La función que ya importamos de AuthService
});

initPage();