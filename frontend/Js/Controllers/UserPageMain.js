import { fetchEvents } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';

// Variables globales para las Vistas
const viewCatalog = document.getElementById('view-catalog');
const viewSectors = document.getElementById('view-sectors');
const sectorsGrid = document.getElementById('sectors-grid');

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

// Actualizamos la función que escucha los clics
function attachButtonEvents() {
    const buttons = document.querySelectorAll('.btn-select-seats');
    
    buttons.forEach(button => {
        button.addEventListener('click', async (e) => {
            const eventId = e.target.getAttribute('data-id');
            
            // 1. Ocultar catálogo, mostrar sectores
            viewCatalog.classList.add('d-none'); // Desaparece
            viewSectors.classList.remove('d-none'); // Aparece
            
            // 2. Poner un mensaje de carga
            sectorsGrid.innerHTML = '<div class="col-12 text-center"><div class="spinner-border text-light" role="status"></div></div>';
            
            // 3. Traer los sectores de la API
            try {
                const responseData = await fetchSectorsByEvent(eventId);
                const sectorsList = responseData.sectors ? responseData.sectors : responseData;
                
                // Limpiamos el spinner
                sectorsGrid.innerHTML = '';

                // ¿El evento no tiene sectores cargados en la BD?
                if (!sectorsList || sectorsList.length === 0) {
                    sectorsGrid.innerHTML = '<div class="col-12 text-center text-muted">No hay sectores disponibles para este evento.</div>';
                    return;
                }

                // Generamos el HTML de todas las tarjetas
                let sectorsHtml = '';
                sectorsList.forEach(sector => {
                    sectorsHtml += createSectorCard(sector);
                });
                sectorsGrid.innerHTML = sectorsHtml;

                // 4. Activar los botones nuevos de "Ver Butacas"
                attachSectorButtonEvents();

            } catch (error) {
                console.error(error);
                sectorsGrid.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar sectores.</div>';
            }
        });
    });
}

// Configurar el botón de volver
document.getElementById('btn-back-catalog').addEventListener('click', () => {
    viewSectors.classList.add('d-none');
    viewCatalog.classList.remove('d-none');
});

function attachSectorButtonEvents() {
    const btnViewSeats = document.querySelectorAll('.btn-view-seats');
    
    btnViewSeats.forEach(button => {
        button.addEventListener('click', (e) => {
            const sectorId = e.target.getAttribute('data-sector-id');
            console.log(`🚀 ¡Preparando el mapa de butacas para el Sector ID: ${sectorId}!`);
            
            // Acá programaremos la Rebanada B - Parte 2 (El mapa de butacas real)
        });
    });
}

// Arrancar
initPage();