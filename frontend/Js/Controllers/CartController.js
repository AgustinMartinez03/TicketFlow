import { getMisReservas, clearMisReservas } from '../Services/ReservationStorage.js';

let temporizadorInterval = null;

export function detenerTemporizador() {
    if (temporizadorInterval) clearInterval(temporizadorInterval);
    document.getElementById('carrito-container').style.display = 'none';
    document.body.style.paddingBottom = '0px';
    // Limpiamos el tiempo global de la sesión al detener
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