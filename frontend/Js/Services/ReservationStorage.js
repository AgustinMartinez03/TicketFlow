export function getMisReservas() {
    const data = sessionStorage.getItem('misReservasActivas');
    return data ? JSON.parse(data) : [];
}

export function addMiReserva(reserva) {
    const reservas = getMisReservas();
    reservas.push(reserva);
    sessionStorage.setItem('misReservasActivas', JSON.stringify(reservas));
}

export function clearMisReservas() {
    sessionStorage.removeItem('misReservasActivas');
}