import { reserveSeatApi, fetchSeatsBySector } from '../Services/SeatService.js';
import { getMisReservas, addMiReserva, clearMisReservas } from '../Services/ReservationStorage.js';
import { iniciarCarritoConTemporizador, detenerTemporizador } from './CartController.js';
import { createSeatsGridHtml } from '../Components/SeatsComponent.js';
import { getUserIdFromToken } from '../Services/AuthService.js';

export async function recargarGrillaButacas(sectorId) {
    try {
        const responseData = await fetchSeatsBySector(sectorId);
        const seatsList = responseData.seats ? responseData.seats : responseData;
        renderSeatsGrid(seatsList, sectorId);
    } catch (error) {
        console.error("Error al recargar grilla:", error);
    }
}

export function renderSeatsGrid(seatsList, sectorId) { 
    const seatsGrid = document.getElementById('seats-grid');
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

    const reservasActivas = getMisReservas(); 
    seatsGrid.innerHTML = createSeatsGridHtml(seatsList, sectorId, reservasActivas);
    
    attachSeatClickEvents();
}

function attachSeatClickEvents() {
    const CURRENT_USER_ID = getUserIdFromToken();
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

            if (seatBtn.classList.contains('seat-my-reserved')) {
                Swal.fire({
                    toast: true, position: 'top-end', showConfirmButton: false, timer: 2500,
                    icon: 'info', title: 'Esta butaca ya está en tu carrito',
                    background: 'var(--card-bg)', color: 'var(--text-main)'
                });
                return; 
            }

            if (seatBtn.classList.contains('seat-available')) {
                Swal.fire({
                    title: '¿Confirmar Reserva?',
                    text: `Estás por seleccionar la Fila ${row}, Butaca ${number}. ¿Deseas continuar?`,
                    icon: 'question', showCancelButton: true, confirmButtonColor: 'var(--neon-purple)', cancelButtonColor: 'var(--border-color)',
                    confirmButtonText: 'Sí, reservar', cancelButtonText: 'Cancelar', background: 'var(--card-bg)', color: 'var(--text-main)'
                }).then(async(result) => {
                    if (result.isConfirmed) {
                        Swal.fire({ title: 'Procesando reserva...', background: 'var(--card-bg)', color: 'var(--text-main)', allowOutsideClick: false, didOpen: () => { Swal.showLoading(); }});

                        try {
                            const responseData = await reserveSeatApi(seatId, CURRENT_USER_ID);
                            addMiReserva({ seatId: seatId, reservationId: responseData.reservationId }); 
                            
                            let expiracionGlobal = sessionStorage.getItem('cartExpiration');
                            if (!expiracionGlobal) {
                                expiracionGlobal = Date.now() + (5 * 60 * 1000);
                                sessionStorage.setItem('cartExpiration', expiracionGlobal);
                            }
                            
                            iniciarCarritoConTemporizador(expiracionGlobal);
                            seatBtn.classList.remove('seat-available');
                            seatBtn.classList.add('seat-my-reserved');

                            Swal.fire({ title: '¡Reserva Confirmada!', text: `Tu butaca ha sido agregada al carrito.`, icon: 'success', background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)' });
                        } catch (error) {
                            if (error.status === 409) {
                                seatBtn.classList.remove('seat-available');
                                seatBtn.classList.add('seat-reserved', 'disabled');
                                Swal.fire({ title: '¡Asiento no disponible!', text: 'Otro usuario ganó esta butaca.', icon: 'warning', background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)'});
                            } else {
                                Swal.fire({ title: '¡Ups!', text: error.message || 'No se pudo completar la reserva.', icon: 'error', background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)'});
                            }
                        }
                    }
                });
            }
        });
    });
}