const API_BASE_URL = 'http://localhost:5041/api/v1';

export async function processPaymentApi(reservationId, creditCardToken) {
    const response = await fetch(`${API_BASE_URL}/payments`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            reservationId: reservationId,
            creditCardToken: creditCardToken
        })
    });

    if (!response.ok) {
        const errorData = await response.json().catch(() => null);
        throw { 
            status: response.status, 
            message: errorData?.message || "Error procesando el pago en el servidor" 
        };
    }

    return await response.json();
}