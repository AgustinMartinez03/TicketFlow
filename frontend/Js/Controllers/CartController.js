import { getMiReserva, clearMiReserva } from '../Services/ReservationStorage.js';

let temporizadorInterval = null;

export function detenerTemporizador() {
    if (temporizadorInterval) clearInterval(temporizadorInterval);
    document.getElementById('carrito-container').style.display = 'none';
    document.body.style.paddingBottom = '0px';
}

export function iniciarCarritoConTemporizador(reservationId, currentSectorId, expiresAtTimestamp) {
    document.getElementById('carrito-container').style.display = 'block';
    document.body.style.paddingBottom = '150px'; 
    
    const timerElement = document.getElementById('contador-carrito');

    if (temporizadorInterval) clearInterval(temporizadorInterval);

    temporizadorInterval = setInterval(() => {
        const ahora = Date.now();
        const tiempoRestanteMs = expiresAtTimestamp - ahora;

        if (tiempoRestanteMs <= 0) {
            detenerTemporizador();

            const miReservaActual = getMiReserva();
            if (miReservaActual) {
                const btnNaranja = document.querySelector(`button[data-seat-id="${miReservaActual.seatId}"]`);
                if (btnNaranja) {
                    btnNaranja.classList.remove('seat-my-reserved', 'disabled');
                    btnNaranja.classList.add('seat-available');
                }
            }

            clearMiReserva();
            
            Swal.fire({
                icon: 'warning',
                title: 'Tiempo expirado',
                text: 'El tiempo para pagar ha expirado. Tu butaca ha sido liberada.',
                background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#8b5cf6'
            });
            
            return; 
        }

        let segundosTotales = Math.floor(tiempoRestanteMs / 1000);
        let minutos = Math.floor(segundosTotales / 60);
        let segundos = segundosTotales % 60;
        
        timerElement.innerText = `${minutos.toString().padStart(2, '0')}:${segundos.toString().padStart(2, '0')}`;
    }, 1000);
}