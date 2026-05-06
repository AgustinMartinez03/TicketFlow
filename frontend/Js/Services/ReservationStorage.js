export function getMiReserva() {
    const data = sessionStorage.getItem('miReservaActiva');
    return data ? JSON.parse(data) : null;
}

export function setMiReserva(reserva) {
    sessionStorage.setItem('miReservaActiva', JSON.stringify(reserva));
}

export function clearMiReserva() {
    sessionStorage.removeItem('miReservaActiva');
}