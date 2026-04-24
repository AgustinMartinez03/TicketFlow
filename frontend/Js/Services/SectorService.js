const API_BASE_URL = "http://localhost:5041/api/v1"; // Recordá verificar tu puerto

export async function fetchSectorsByEvent(eventId) {
    try {
        const response = await fetch(`${API_BASE_URL}/Events/${eventId}/sectors`);
        if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
        return await response.json();
    } catch (error) {
        console.error("Error en SectorService:", error);
        throw error;
    }
}