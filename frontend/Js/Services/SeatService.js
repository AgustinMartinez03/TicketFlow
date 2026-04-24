const API_BASE_URL = "http://localhost:5041/api/v1"; 

export async function fetchSeatsBySector(sectorId) {
    try {
        const response = await fetch(`${API_BASE_URL}/Sectors/${sectorId}/seats`);
        if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
        return await response.json();
    } catch (error) {
        console.error("Error en SeatService:", error);
        throw error;
    }
}


// Agregamos esta función al final de SeatService.js

export async function reserveSeatApi(seatId, userId) {
    try {
        // AJUSTE CLAVE: Revisa tu Swagger para confirmar que la URL sea exactamente esta.
        // A veces es /Reservations, o /Seats/reserve
        const response = await fetch(`${API_BASE_URL}/Seats/reserve`, {
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
            // Si el backend nos rechaza (ej: butaca ya ocupada), capturamos el error
            const errorData = await response.json();
            throw new Error(errorData.message || 'Error al procesar la reserva');
        }

        return await response.json();
    } catch (error) {
        console.error("Error en reserveSeatApi:", error);
        throw error;
    }
}