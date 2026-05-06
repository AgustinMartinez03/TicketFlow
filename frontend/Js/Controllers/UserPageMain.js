import { fetchEvents } from '../Services/EventService.js';
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

async function initPage() {
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
const CURRENT_USER_ID = "1";

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

document.getElementById('btn-back-sectors').addEventListener('click', () => {
    viewSeats.classList.add('d-none');
    viewSectors.classList.remove('d-none');
});

initPage();