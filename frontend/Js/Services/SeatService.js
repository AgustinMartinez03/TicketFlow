const API_BASE_URL = "http://localhost:5041/api/v1"; 

export async function fetchSeatsBySector(sectorId) {
    try {
        const response = await fetch(`${API_BASE_URL}/sectors/${sectorId}/seats`);
        if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
        return await response.json();
    } catch (error) {
        console.error("Error en SeatService:", error);
        throw error;
    }
}

export async function reserveSeatApi(seatId, userId) {
    try {

        const response = await fetch(`${API_BASE_URL}/reservations`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                seatId: seatId,
                userId: userId
            })
        });

        if (!response.ok) {
            const errorData = await response.json();
            throw new Error(errorData.message || 'Error al procesar la reserva');
        }

        return await response.json();
    } catch (error) {
        console.error("Error en reserveSeatApi:", error);
        throw error;
    }
}