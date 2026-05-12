import { getAuthToken } from './AuthService.js';

const API_BASE_URL = 'https://localhost:7157/api/v1';

export async function processPaymentApi(reservationIds, creditCardToken) {
    const response = await fetch(`${API_BASE_URL}/payments`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${getAuthToken()}`
        },
        body: JSON.stringify({
            reservationIds: reservationIds,
            creditCardToken: creditCardToken
        })
    });

    if (!response.ok) {
        const errorData = await response.json().catch(() => ({}));
        
        if (response.status === 401) {
            throw { status: 401, message: 'Tu sesión ha expirado. Por favor, vuelve a iniciar sesión.' };
        }

        throw { 
            status: response.status, 
            message: errorData?.message || "Error procesando el pago en el servidor" 
        };
    }

    return await response.json();
}