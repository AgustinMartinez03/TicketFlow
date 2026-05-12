import { getAuthToken } from './AuthService.js';

const API_BASE_URL = "https://localhost:7157/api/v1"; 

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
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${getAuthToken()}`
            },
            body: JSON.stringify({
                seatId: seatId,
                userId: userId
            })
        });

        if (!response.ok) {
            const errorData = await response.json().catch(() => ({})); 

            if (response.status === 401) {
                throw new Error('Tu sesión ha expirado o no tienes permisos. Por favor, vuelve a iniciar sesión.');
            }

            if (response.status === 409) {
                const error = new Error(errorData.message || 'Error de concurrencia');
                error.status = 409; 
                throw error;
            }
            
            throw new Error(errorData.message || 'Error al procesar la reserva');
        }

        return await response.json();
    } catch (error) {
        console.error("Error en reserveSeatApi:", error);
        throw error;
    }
}