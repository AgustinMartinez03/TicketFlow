import { fetchEvents } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';

async function initPage() {
    const gridContainer = document.getElementById('events-grid');
    
    try {
        // 1. Pedir los datos a la API y guardarlos en "responseData"
        const responseData = await fetchEvents();
        
        // Extraer el array real mirando la propiedad "events" de tu JSON
        const eventsList = responseData.events ? responseData.events : responseData; 

        // 2. Limpiar el spinner de carga
        gridContainer.innerHTML = ''; 

        // 3. ¿No hay eventos?
        if (!eventsList || eventsList.length === 0) {
            gridContainer.innerHTML = '<div class="col-12 text-center text-muted">No hay eventos disponibles.</div>';
            return;
        }

        // 4. Transformar los datos en HTML y pegarlos en la grilla
        let cardsHtml = '';
        eventsList.forEach(event => {
            cardsHtml += createEventCard(event);
        });
        gridContainer.innerHTML = cardsHtml;

        // 5. Escuchar los clics en los botones
        attachButtonEvents();

    } catch (error) {
        console.error("Error real capturado:", error);
        gridContainer.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar el catálogo.</div>';
    }
}

function attachButtonEvents() {
    // Buscamos todos los botones recién creados
    const buttons = document.querySelectorAll('.btn-select-seats');
    
    buttons.forEach(button => {
        button.addEventListener('click', (e) => {
            // Leemos el ID del evento que guardamos en data-id
            const eventId = e.target.getAttribute('data-id');
            console.log(`¡Navegando a los sectores del evento ID: ${eventId}!`);
            
            // Acá luego haremos la navegación a la vista de Sectores/Butacas
            // window.location.href = `sectors.html?eventId=${eventId}`; 
        });
    });
}

// Arrancar
initPage();