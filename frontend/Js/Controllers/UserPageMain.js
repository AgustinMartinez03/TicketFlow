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

// 👇 1. VARIABLES DE ESTADO Y MANEJO DE SESSION STORAGE
const CURRENT_USER_ID = "1";
let temporizadorInterval = null;

// Funciones para manejar la única reserva permitida en el SessionStorage
function getMiReserva() {
    const data = sessionStorage.getItem('miReservaActiva');
    return data ? JSON.parse(data) : null;
}

function setMiReserva(reserva) {
    sessionStorage.setItem('miReservaActiva', JSON.stringify(reserva));
}

function clearMiReserva() {
    sessionStorage.removeItem('miReservaActiva');
}

// 👇 2. TEMPORIZADOR A PRUEBA DE F5 Y WORKER DEL BACKEND
function iniciarCarritoConTemporizador(reservationId, currentSectorId, expiresAtTimestamp) {
    document.getElementById('carrito-container').style.display = 'block';
    document.body.style.paddingBottom = '150px'; 
    
    const timerElement = document.getElementById('contador-carrito');

    if (temporizadorInterval) clearInterval(temporizadorInterval);

    temporizadorInterval = setInterval(() => {
        const ahora = Date.now();
        const tiempoRestanteMs = expiresAtTimestamp - ahora;

        if (tiempoRestanteMs <= 0) {
            clearInterval(temporizadorInterval);
            document.getElementById('carrito-container').style.display = 'none';
            document.body.style.paddingBottom = '0px';

            // 🪄 TRUCO VISUAL: Buscamos la butaca naranja y la forzamos a verde 
            // para no esperar al Worker del backend.
            const miReservaActual = getMiReserva();
            if (miReservaActual) {
                const btnNaranja = document.querySelector(`button[data-seat-id="${miReservaActual.seatId}"]`);
                if (btnNaranja) {
                    btnNaranja.classList.remove('seat-my-reserved', 'disabled');
                    btnNaranja.classList.add('seat-available');
                }
            }

            clearMiReserva(); // Limpiamos la memoria
            
            Swal.fire({
                icon: 'warning',
                title: 'Tiempo expirado',
                text: 'El tiempo para pagar ha expirado. Tu butaca ha sido liberada.',
                background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#8b5cf6'
            });
            // 🛑 Eliminamos el ".then(() => recargarGrillaButacas)" para no traer datos "viejos" del backend.
            
            return; 
        }

        let segundosTotales = Math.floor(tiempoRestanteMs / 1000);
        let minutos = Math.floor(segundosTotales / 60);
        let segundos = segundosTotales % 60;
        
        timerElement.innerText = `${minutos.toString().padStart(2, '0')}:${segundos.toString().padStart(2, '0')}`;
    }, 1000);
}

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
            // Si está viva, reactivamos el temporizador visualmente (Cubre el caso del F5)
            iniciarCarritoConTemporizador(miReserva.reservationId, sectorId, miReserva.expiresAt);
        } else {
            // Si el tiempo pasó mientras estaba offline o hizo F5 tarde, la borramos
            clearMiReserva(); 
        }
    } else {
        // Nos aseguramos de ocultar el carrito si no hay nada
        document.getElementById('carrito-container').style.display = 'none';
        document.body.style.paddingBottom = '0px';
        if (temporizadorInterval) clearInterval(temporizadorInterval);
    }

    const reservaActiva = getMiReserva(); // Volvemos a leer por si la borramos arriba

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
                // Chequeamos contra el SessionStorage
                const esMia = reservaActiva && reservaActiva.seatId === seat.id;
                if (esMia) {
                    statusClass = 'seat-my-reserved'; 
                    disabledClass = ''; // Se puede clickear
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

                        const response = await fetch('http://localhost:5041/api/v1/payments', {
                            method: 'POST',
                            headers: { 'Content-Type': 'application/json' },
                            body: JSON.stringify({
                                reservationId: miReservaActual.reservationId,
                                creditCardToken: formValues
                            })
                        });

                        if (!response.ok) throw new Error("Error procesando el pago");

                        // Éxito
                        clearInterval(temporizadorInterval);
                        document.getElementById('carrito-container').style.display = 'none';
                        document.body.style.paddingBottom = '0px';
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
                        Swal.fire({ title: 'Error', text: 'El pago no pudo procesarse.', icon: 'error', background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'});
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