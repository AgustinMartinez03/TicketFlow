import { fetchEvents } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';
import { fetchSeatsBySector, reserveSeatApi } from '../Services/SeatService.js';

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

// 👇 1. VARIABLES DE ESTADO Y TEMPORIZADOR
const CURRENT_USER_ID = "1";
let misReservas = []; // Formato: [{ seatId: "...", reservationId: "..." }]
let temporizadorInterval = null;

function iniciarCarritoConTemporizador(reservationId, currentSectorId) {
    document.getElementById('carrito-container').style.display = 'block';
    
    let tiempoRestante = 300; 
    const timerElement = document.getElementById('contador-carrito');

    if (temporizadorInterval) clearInterval(temporizadorInterval);

    temporizadorInterval = setInterval(() => {
        let minutos = Math.floor(tiempoRestante / 60);
        let segundos = tiempoRestante % 60;
        
        timerElement.innerText = `${minutos.toString().padStart(2, '0')}:${segundos.toString().padStart(2, '0')}`;

        if (tiempoRestante <= 0) {
            clearInterval(temporizadorInterval);
            document.getElementById('carrito-container').style.display = 'none';
            misReservas = []; // Limpiamos memoria
            
            Swal.fire({
                icon: 'warning',
                title: 'Tiempo expirado',
                text: 'El tiempo para pagar ha expirado. Tu butaca ha sido liberada.',
                background: '#1a1d24',
                color: '#ffffff',
                confirmButtonColor: '#8b5cf6'
            }).then(() => {
                recargarGrillaButacas(currentSectorId); 
            });
        }
        tiempoRestante--;
    }, 1000);
}

// Función auxiliar para recargar la grilla silenciosamente
async function recargarGrillaButacas(sectorId) {
    try {
        const responseData = await fetchSeatsBySector(sectorId);
        const seatsList = responseData.seats ? responseData.seats : responseData;
        renderSeatsGrid(seatsList, sectorId);
    } catch (error) {
        console.error("Error al recargar grilla:", error);
    }
}

// 👇 2. RENDERIZADO INTELIGENTE DE BUTACAS
function renderSeatsGrid(seatsList, sectorId) { 
    const rows = {};
    seatsList.forEach(seat => {
        if (!rows[seat.rowIdentifier]) rows[seat.rowIdentifier] = [];
        rows[seat.rowIdentifier].push(seat);
    });

    let html = '';

    Object.keys(rows).sort().forEach(rowKey => {
        const seatsInRow = rows[rowKey];
        seatsInRow.sort((a, b) => a.seatNumber - b.seatNumber);

        html += `
            <div class="d-flex align-items-center mb-2 seat-row">
                <div class="row-label">${rowKey}</div>
                <div class="d-flex gap-2 flex-nowrap flex-grow-1 justify-content-center">
        `;

        seatsInRow.forEach(seat => {
            let statusClass = '';
            let disabledClass = '';

            if (seat.status === 'Available') {
                statusClass = 'seat-available';
            } else if (seat.status === 'Reserved') {
                const esMia = misReservas.some(r => r.seatId === seat.id);
                if (esMia) {
                    statusClass = 'seat-my-reserved'; 
                    disabledClass = ''; // ¡Fundamental! No debe estar disabled para poder clickear
                } else {
                    statusClass = 'seat-reserved';
                    disabledClass = 'disabled'; 
                }
            } else {
                statusClass = 'seat-sold';
                disabledClass = 'disabled';
            }

            html += `
                <button class="btn btn-sm seat-btn ${statusClass} ${disabledClass}"
                        data-seat-id="${seat.id}"
                        data-seat-row="${seat.rowIdentifier}"
                        data-seat-number="${seat.seatNumber}"
                        data-sector-id="${sectorId}"
                        title="Fila ${seat.rowIdentifier} - Butaca ${seat.seatNumber}">
                    ${seat.seatNumber}
                </button>
            `;
        });

        html += `
                </div>
                <div class="row-label text-end">${rowKey}</div>
            </div>
        `;
    });

    seatsGrid.innerHTML = html;
    attachSeatClickEvents(); // Volvemos a enlazar los eventos a los nuevos botones
}

// 👇 3. LÓGICA DE CLIC (RESERVAR, PAGAR Y ERROR 409)
function attachSeatClickEvents() {
    // Seleccionamos TODOS los botones que no sean disabled (verdes y naranjas)
    const clickableSeats = document.querySelectorAll('.seat-btn:not(.disabled)');
    
    clickableSeats.forEach(seatBtn => {
        // Removemos eventos previos para evitar ejecuciones dobles si se recarga la grilla
        seatBtn.replaceWith(seatBtn.cloneNode(true));
    });

    // Volvemos a seleccionar tras el clonado
    const newClickableSeats = document.querySelectorAll('.seat-btn:not(.disabled)');

    newClickableSeats.forEach(seatBtn => {
        seatBtn.addEventListener('click', async (e) => {
            
            const seatId = e.target.getAttribute('data-seat-id');
            const row = e.target.getAttribute('data-seat-row');
            const number = e.target.getAttribute('data-seat-number');
            const sectorId = e.target.getAttribute('data-sector-id'); 

            // -- ESCENARIO A: PAGO DE BUTACA NARANJA --
            if (seatBtn.classList.contains('seat-my-reserved')) {
                const miReserva = misReservas.find(r => r.seatId === seatId);
                
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
                    background: '#1a1d24',
                    color: '#ffffff',
                    confirmButtonColor: '#10b981',
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

                        const response = await fetch('http://localhost:5041/api/v1/payments', {
                            method: 'POST',
                            headers: { 'Content-Type': 'application/json' },
                            body: JSON.stringify({
                                reservationId: miReserva.reservationId,
                                creditCardToken: formValues
                            })
                        });

                        if (!response.ok) throw new Error("Error procesando el pago");

                        clearInterval(temporizadorInterval);
                        document.getElementById('carrito-container').style.display = 'none';
                        misReservas = misReservas.filter(r => r.seatId !== seatId);

                        // TRUCO VISUAL: La pintamos de gris (sold) inmediatamente
                        seatBtn.classList.remove('seat-my-reserved');
                        seatBtn.classList.add('seat-sold', 'disabled');

                        Swal.fire({
                            title: '¡Pago Exitoso!',
                            text: 'Disfruta tu evento.',
                            icon: 'success',
                            background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#10b981'
                        });

                    } catch (error) {
                        Swal.fire({ title: 'Error', text: 'El pago no pudo procesarse.', icon: 'error', background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'});
                    }
                }
                return; 
            }

            // -- ESCENARIO B: RESERVAR BUTACA VERDE --
            if (seatBtn.classList.contains('seat-available')) {
                Swal.fire({
                    title: '¿Confirmar Reserva?',
                    text: `Estás por seleccionar la Fila ${row}, Butaca ${number}. ¿Deseas continuar?`,
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: '#8b5cf6',
                    cancelButtonColor: '#3f3f46',
                    confirmButtonText: 'Sí, reservar',
                    cancelButtonText: 'Cancelar',
                    background: '#1a1d24',
                    color: '#ffffff'
                }).then(async(result) => {
                    
                    if (result.isConfirmed) {
                        
                        Swal.fire({
                            title: 'Procesando reserva...',
                            background: '#1a1d24',
                            color: '#ffffff',
                            allowOutsideClick: false,
                            didOpen: () => {
                                Swal.showLoading();
                            }
                        });

                        try {
                            const responseData = await reserveSeatApi(seatId, CURRENT_USER_ID);
                            
                            misReservas.push({ seatId: seatId, reservationId: responseData.reservationId });
                            
                            iniciarCarritoConTemporizador(responseData.reservationId, sectorId);

                            // TRUCO VISUAL: La pintamos de naranja inmediatamente antes de recargar
                            seatBtn.classList.remove('seat-available');
                            seatBtn.classList.add('seat-my-reserved');

                            Swal.fire({
                                title: '¡Reserva Confirmada!',
                                text: `Tu butaca ha sido reservada con éxito. Tienes 5 minutos para pagar.`,
                                icon: 'success',
                                background: '#1a1d24',
                                color: '#ffffff',
                                confirmButtonColor: '#10b981'
                            });

                        } catch (error) {
                            if (error.status === 409) {
                                // TRUCO VISUAL: Nos ganaron, la pintamos amarilla
                                seatBtn.classList.remove('seat-available');
                                seatBtn.classList.add('seat-reserved', 'disabled');

                                Swal.fire({
                                    title: '¡Asiento no disponible!',
                                    text: 'Otro usuario ganó esta butaca milisegundos antes. Por favor elige otra.',
                                    icon: 'warning',
                                    background: '#1a1d24',
                                    color: '#ffffff',
                                    confirmButtonColor: '#ef4444'
                                });
                            } else {
                                Swal.fire({
                                    title: '¡Ups!',
                                    text: error.message || 'No se pudo completar la reserva.',
                                    icon: 'error',
                                    background: '#1a1d24',
                                    color: '#ffffff',
                                    confirmButtonColor: '#ef4444'
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