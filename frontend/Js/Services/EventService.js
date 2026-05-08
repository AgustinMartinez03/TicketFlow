import { getAuthToken } from './AuthService.js';
const API_BASE_URL = "https://localhost:7157/api/v1";

export async function fetchEvents() {
    try {
        const response = await fetch(`${API_BASE_URL}/events`);
        if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
        return await response.json();
    } catch (error) {
        console.error("Error en EventService:", error);
        throw error;
    }
}

export async function createEventApi(eventData) {
    const response = await fetch(`${API_BASE_URL}/events`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${getAuthToken()}`
        },
        body: JSON.stringify(eventData)
    });

    if (!response.ok) {
        const errorData = await response.json().catch(() => ({}));
        
        if (response.status === 401 || response.status === 403) {
            throw new Error('No tienes permisos de Administrador para realizar esta acción.');
        }
        
        throw new Error(errorData.message || 'Error al crear el evento en el servidor.');
    }

    return await response.json();
}