// Importamos la herramienta que nos trae los datos
import { fetchEvents } from '../Services/EventService.js';

console.log("Controlador de Usuario inicializado. Cargando catálogo...");

// Función principal que arranca la página
async function initPage() {
    try {
        const events = await fetchEvents();
        console.log("¡Los eventos llegaron a la capa del controlador!", events);
        // Próximo paso: pasárselos al componente "Card" para que los dibuje en HTML
    } catch (error) {
        // Acá luego usaremos SweetAlert para mostrar el error en rojo neón
        console.error("Hubo un problema al cargar la página inicial");
    }
}

// Ejecutamos la función al cargar el script
initPage();