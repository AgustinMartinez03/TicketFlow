const API_BASE_URL = "http://localhost:5041/api/v1"; // Acordate de usar TU puerto

// Función que hace el Fetch y devuelve los datos limpios
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