import { getMisReservas, clearMisReservas } from '../Services/ReservationStorage.js';
import { processPaymentApi } from '../Services/PaymentService.js';

let temporizadorInterval = null;

export function detenerTemporizador() {
    if (temporizadorInterval) clearInterval(temporizadorInterval);
    document.getElementById('carrito-container').style.display = 'none';
    document.body.style.paddingBottom = '0px';
    sessionStorage.removeItem('cartExpiration'); 
}

export function actualizarContadorCarrito() {
    const reservas = getMisReservas();
    const titleElement = document.querySelector('.cart-title');

    if (titleElement) {
        titleElement.innerHTML = `🎟️ Tienes <span id="cart-count">${reservas.length}</span> reserva${reservas.length !== 1 ? 's' : ''} pendiente${reservas.length !== 1 ? 's' : ''}`;
    }
}

export function iniciarCarritoConTemporizador(expiresAtTimestamp) {
    document.getElementById('carrito-container').style.display = 'block';
    document.body.style.paddingBottom = '150px'; 
    
    actualizarContadorCarrito();
    
    const timerElement = document.getElementById('contador-carrito');

    if (temporizadorInterval) clearInterval(temporizadorInterval);

    temporizadorInterval = setInterval(() => {
        const ahora = Date.now();
        const tiempoRestanteMs = expiresAtTimestamp - ahora;

        if (tiempoRestanteMs <= 0) {
            detenerTemporizador();

            const misReservasActuales = getMisReservas();
            
            misReservasActuales.forEach(reserva => {
                const btnNaranja = document.querySelector(`button[data-seat-id="${reserva.seatId}"]`);
                if (btnNaranja) {
                    btnNaranja.classList.remove('seat-my-reserved', 'disabled');
                    btnNaranja.classList.add('seat-available');
                }
            });

            clearMisReservas();
            
            Swal.fire({
                icon: 'warning',
                title: 'Tiempo expirado',
                text: 'El tiempo para pagar ha expirado. Tus butacas han sido liberadas.',
                background: 'var(--card-bg)',
                color: 'var(--text-main)', 
                confirmButtonColor: 'var(--neon-purple)'
            });
            
            return; 
        }

        let segundosTotales = Math.floor(tiempoRestanteMs / 1000);
        let minutos = Math.floor(segundosTotales / 60);
        let segundos = segundosTotales % 60;
        
        timerElement.innerText = `${minutos.toString().padStart(2, '0')}:${segundos.toString().padStart(2, '0')}`;
    }, 1000);
}

export function setupCartEvents() {
    const btnPayCart = document.getElementById('btn-pay-cart');
    if (btnPayCart) {
        btnPayCart.addEventListener('click', async () => {
            const reservas = getMisReservas();
            if (reservas.length === 0) return;

            const reservationIds = reservas.map(r => r.reservationId);

            const { value: formValues } = await Swal.fire({
                title: 'Pagar Carrito',
                html: `
                    <p class="text-light mb-3">Estás a punto de pagar <strong>${reservas.length}</strong> butacas.</p>
                    <input id="swal-input1" class="swal2-input bg-dark text-light border-secondary" placeholder="Número de Tarjeta (Simulado)">
                `,
                focusConfirm: false, showCancelButton: true, confirmButtonText: 'Procesar Pago', cancelButtonText: 'Cancelar',
                background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)',
                preConfirm: () => document.getElementById('swal-input1').value
            });

            if (formValues) {
                try {
                    Swal.fire({ title: 'Procesando pago...', background: 'var(--card-bg)', color: 'var(--text-main)', allowOutsideClick: false, didOpen: () => { Swal.showLoading(); }});

                    await processPaymentApi(reservationIds, formValues);

                    detenerTemporizador();
                    clearMisReservas();

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
}