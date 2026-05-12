import { getUserIdFromToken, logout } from '../Services/AuthService.js';
import { fetchEvents, createEventApi } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';
import { fetchSeatsBySector, reserveSeatApi } from '../Services/SeatService.js';
import { processPaymentApi } from '../Services/PaymentService.js';
import { getMisReservas, addMiReserva, clearMisReservas } from '../Services/ReservationStorage.js';
import { iniciarCarritoConTemporizador, detenerTemporizador, actualizarContadorCarrito } from './CartController.js';
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

let currentPage = 1;
const pageSize = 10;

async function initPage(page = 1) {
    currentPage = page; // Actualizamos la página actual

    // 1. IDENTIDAD Y ROLES (Lo que ya tenías)
    const userName = sessionStorage.getItem('user_name');
    const nameDisplay = document.getElementById('user-name-display');
    
    if (userName && nameDisplay) {
        nameDisplay.innerText = `Usuario: ${userName}`;
    }

    const userRole = sessionStorage.getItem('user_role');
    if (userRole === 'Admin') {
        adminControls.classList.remove('d-none');
    }
    
    // 2. CAPTURAR CONTENEDORES
    const gridContainer = document.getElementById('events-grid');
    const paginationContainer = document.getElementById('pagination-container'); // 👈 El nuevo contenedor
    
    try {
        // 3. PETICIÓN PAGINADA
        const responseData = await fetchEvents(currentPage, pageSize);
        
        // Extraemos los datos (soportando tanto tu estructura vieja como la nueva paginada)
        const eventsList = responseData.events ? responseData.events : responseData; 
        const totalPages = responseData.totalPages || 1; // Si no viene, asumimos 1

        gridContainer.innerHTML = ''; 

        // 4. SI NO HAY EVENTOS
        if (!eventsList || eventsList.length === 0) {
            gridContainer.innerHTML = '<div class="col-12 text-center text-muted">No hay eventos disponibles.</div>';
            if (paginationContainer) paginationContainer.innerHTML = ''; // Limpiamos la paginación
            return;
        }

        // 5. RENDERIZAR TARJETAS
        let cardsHtml = '';
        eventsList.forEach(event => {
            cardsHtml += createEventCard(event);
        });
        gridContainer.innerHTML = cardsHtml;

        attachButtonEvents();

        // 6. RENDERIZAR PAGINACIÓN (👇 Lo nuevo)
        if (paginationContainer) {
            renderPagination(totalPages);
        }

    } catch (error) {
        console.error("Error real capturado:", error);
        gridContainer.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar el catálogo.</div>';
        if (paginationContainer) paginationContainer.innerHTML = '';
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

            seatsGrid.innerHTML = '<div class="text-center my-5"><div class="spinner-border spinner-neon" role="status"></div><p class="mt-2 text-muted">Armando el escenario...</p></div>';

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
    // Verificamos si hay reservas activas en memoria y si sigue vivo el tiempo global
    const misReservas = getMisReservas();
    const expiracionGlobal = sessionStorage.getItem('cartExpiration');

    if (misReservas.length > 0 && expiracionGlobal) {
        if (expiracionGlobal > Date.now()) {
            iniciarCarritoConTemporizador(expiracionGlobal);
        } else {
            clearMisReservas(); 
        }
    } else {
        detenerTemporizador();
    }

    const reservasActivas = getMisReservas(); // Volvemos a leer por si se borraron arriba

    // 👇 Le pasamos el ARRAY de reservas al componente visual
    seatsGrid.innerHTML = createSeatsGridHtml(seatsList, sectorId, reservasActivas);
    
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

            // -- ESCENARIO A: CLIC EN BUTACA NARANJA --
            if (seatBtn.classList.contains('seat-my-reserved')) {
                // Como el pago ahora se hace desde el botón "Pagar Todo" del carrito,
                // solo le avisamos al usuario que ya la tiene seleccionada.
                Swal.fire({
                    toast: true, position: 'top-end', showConfirmButton: false, timer: 2500,
                    icon: 'info', title: 'Esta butaca ya está en tu carrito',
                    background: 'var(--card-bg)', color: 'var(--text-main)'
                });
                return; 
            }

            // -- ESCENARIO B: RESERVAR BUTACA VERDE --
            if (seatBtn.classList.contains('seat-available')) {
                
                // NOTA: Eliminamos el bloqueo. ¡Ahora permitimos seguir reservando!

                // Restauramos tu SweetAlert de confirmación original
                Swal.fire({
                    title: '¿Confirmar Reserva?',
                    text: `Estás por seleccionar la Fila ${row}, Butaca ${number}. ¿Deseas continuar?`,
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: 'var(--neon-purple)', cancelButtonColor: 'var(--border-color)',
                    confirmButtonText: 'Sí, reservar', cancelButtonText: 'Cancelar',
                    background: 'var(--card-bg)', color: 'var(--text-main)'
                }).then(async(result) => {
                    if (result.isConfirmed) {
                        Swal.fire({
                            title: 'Procesando reserva...',
                            background: 'var(--card-bg)', color: 'var(--text-main)',
                            allowOutsideClick: false,
                            didOpen: () => { Swal.showLoading(); }
                        });

                        try {
                            const responseData = await reserveSeatApi(seatId, CURRENT_USER_ID);
                            
                            const nuevaReserva = { 
                                seatId: seatId, 
                                reservationId: responseData.reservationId 
                            };
                            
                            addMiReserva(nuevaReserva); // Agregamos al array
                            
                            // LA REGLA DEL PROFE: El tiempo arranca desde la PRIMERA reserva.
                            let expiracionGlobal = sessionStorage.getItem('cartExpiration');
                            if (!expiracionGlobal) {
                                expiracionGlobal = Date.now() + (5 * 60 * 1000);
                                sessionStorage.setItem('cartExpiration', expiracionGlobal);
                            }
                            
                            iniciarCarritoConTemporizador(expiracionGlobal);

                            seatBtn.classList.remove('seat-available');
                            seatBtn.classList.add('seat-my-reserved');

                            // Restauramos tu alerta de éxito original (ajustado el texto al carrito)
                            Swal.fire({
                                title: '¡Reserva Confirmada!',
                                text: `Tu butaca ha sido agregada al carrito. Recuerda pagar antes de que expire el tiempo.`,
                                icon: 'success',
                                background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)'
                            });

                        } catch (error) {
                            if (error.status === 409) {
                                seatBtn.classList.remove('seat-available');
                                seatBtn.classList.add('seat-reserved', 'disabled');

                                Swal.fire({
                                    title: '¡Asiento no disponible!',
                                    text: 'Otro usuario ganó esta butaca milisegundos antes. Por favor elige otra.',
                                    icon: 'warning',
                                    background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)'
                                });
                            } else {
                                Swal.fire({
                                    title: '¡Ups!',
                                    text: error.message || 'No se pudo completar la reserva.',
                                    icon: 'error',
                                    background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)'
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
    
    // 👇 NOTA: Agregamos 'align-items-center' en la clase del row y limpiamos los márgenes de las columnas
    const html = `
        <div class="row g-2 mb-3 sector-entry align-items-center" id="sector-row-${sectorId}">
            <div class="col-md-5">
                <input type="text" class="form-control text-white sector-name admin-input" placeholder="Nombre (ej: VIP)" required>
            </div>
            <div class="col-md-3">
                <input type="number" class="form-control text-white sector-price admin-input fw-normal" placeholder="Precio ($)" min="1" required>
            </div>
            <div class="col-md-3">
                <input type="number" class="form-control text-white sector-capacity admin-input" placeholder="Capacidad" min="1" required>
            </div>
            <div class="col-md-1">
                <button type="button" class="btn btn-outline-danger w-100" onclick="document.getElementById('sector-row-${sectorId}').remove()" title="Eliminar Sector">
                    X
                </button>
            </div>
        </div>
    `;
    
    document.getElementById('sectors-container').insertAdjacentHTML('beforeend', html);
}

document.getElementById('btn-add-sector').addEventListener('click', agregarFilaSector);

// 👇 EVENTO PARA CREAR EL EVENTO Y SUS SECTORES
document.getElementById('form-create-event').addEventListener('submit', async (e) => {
    e.preventDefault(); // Evita que la página recargue

    // 1. Capturamos los datos básicos
    const name = document.getElementById('event-name').value;
    const venue = document.getElementById('event-venue').value;
    const dateInput = document.getElementById('event-date').value;

    // Convertimos la fecha local al formato universal (ISO) que exige el Backend en UTC
    const formattedDate = new Date(dateInput).toISOString();
    
    // 2. Armamos la lista dinámica de sectores
    const sectorsArray = [];
    const sectorEntries = document.querySelectorAll('.sector-entry');

    if (sectorEntries.length === 0) {
        Swal.fire({ 
            icon: 'warning',
            title: 'Atención',
            text: 'Debes agregar al menos un sector.',
            background: 'var(--card-bg)',
            color: 'var(--text-main)'
        });
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
            background: 'var(--card-bg)', color: 'var(--text-main)',
            allowOutsideClick: false,
            didOpen: () => { Swal.showLoading(); }
        });

        await createEventApi(newEventData);

        // Si salió bien...
        Swal.fire({
            icon: 'success',
            title: '¡Evento Creado!',
            text: 'El evento está listo para recibir reservas.',
            background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)'
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
            background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)'
        });
    }
});

function renderPagination(totalPages) {
    const container = document.getElementById('pagination-container');
    container.innerHTML = '';

    if (totalPages <= 1) return; // Si hay una sola página, no mostramos nada

    // Botón Anterior
    const prevDisabled = currentPage === 1 ? 'disabled' : '';
    container.insertAdjacentHTML('beforeend', `
        <li class="page-item ${prevDisabled}">
            <button class="page-link bg-dark text-light border-secondary" onclick="changePage(${currentPage - 1})">Anterior</button>
        </li>
    `);

    // Números de página
    for (let i = 1; i <= totalPages; i++) {
        const activeClass = i === currentPage ? 'active' : '';
        container.insertAdjacentHTML('beforeend', `
            <li class="page-item ${activeClass}">
                <button class="page-link ${i === currentPage ? 'bg-purple border-purple' : 'bg-dark text-light border-secondary'}" 
                        onclick="changePage(${i})">${i}</button>
            </li>
        `);
    }

    // Botón Siguiente
    const nextDisabled = currentPage === totalPages ? 'disabled' : '';
    container.insertAdjacentHTML('beforeend', `
        <li class="page-item ${nextDisabled}">
            <button class="page-link bg-dark text-light border-secondary" onclick="changePage(${currentPage + 1})">Siguiente</button>
        </li>
    `);
}

// Función global para que los botones funcionen
window.changePage = (page) => {
    window.scrollTo({ top: 0, behavior: 'smooth' }); // Efecto pro de volver arriba
    initPage(page);
};

// Al final de UserPageMain.js
document.getElementById('btn-logout').addEventListener('click', () => {
    logout(); // La función que ya importamos de AuthService
});

// 👇 NUEVA LÓGICA DE PAGO DEL CARRITO
const btnPayCart = document.getElementById('btn-pay-cart');
if (btnPayCart) {
    btnPayCart.addEventListener('click', async () => {
        const reservas = getMisReservas();
        if (reservas.length === 0) return;

        // Extraemos solo los IDs para mandar al Backend
        const reservationIds = reservas.map(r => r.reservationId);

        const { value: formValues } = await Swal.fire({
            title: 'Pagar Carrito',
            html: `
                <p class="text-light mb-3">Estás a punto de pagar <strong>${reservas.length}</strong> butacas.</p>
                <input id="swal-input1" class="swal2-input bg-dark text-light border-secondary" placeholder="Número de Tarjeta (Simulado)">
            `,
            focusConfirm: false,
            showCancelButton: true,
            confirmButtonText: 'Procesar Pago',
            cancelButtonText: 'Cancelar',
            background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)',
            preConfirm: () => document.getElementById('swal-input1').value
        });

        if (formValues) {
            try {
                Swal.fire({ title: 'Procesando pago...', background: 'var(--card-bg)', color: 'var(--text-main)', allowOutsideClick: false, didOpen: () => { Swal.showLoading(); }});

                // Mandamos el Array de IDs!
                await processPaymentApi(reservationIds, formValues);

                // Éxito: Limpiamos todo
                detenerTemporizador();
                clearMisReservas();

                // Cambiamos el color de las butacas a vendidas visualmente
                reservas.forEach(reserva => {
                    const btn = document.querySelector(`button[data-seat-id="${reserva.seatId}"]`);
                    if (btn) {
                        btn.classList.remove('seat-my-reserved');
                        btn.classList.add('seat-sold', 'disabled');
                    }
                });

                Swal.fire({ title: '¡Pago Exitoso!', text: 'Disfruta tu evento.', icon: 'success', background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)' });

            } catch (error) {
                Swal.fire({ title: 'Error', text: error.message || 'El pago no pudo procesarse.', icon: 'error', background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)' });
            }
        }
    });
}

// Cierre de Sesión con Confirmación (SweetAlert2)
document.getElementById('btn-logout').addEventListener('click', () => {
    Swal.fire({
        title: '¿Cerrar sesión?',
        text: "Tendrás que volver a ingresar tus credenciales para comprar o crear eventos.",
        icon: 'warning',
        showCancelButton: true,
        background: 'var(--card-bg)',
        color: 'var(--text-main)',
        confirmButtonColor: 'var(--danger)',
        cancelButtonColor: 'var(--border-color)',
        confirmButtonText: 'Sí, salir',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            logout();
        }
    });
});

initPage();