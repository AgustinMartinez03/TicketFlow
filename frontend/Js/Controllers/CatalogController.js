import { fetchEvents } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';
import { fetchSeatsBySector } from '../Services/SeatService.js';
import { renderSeatsGrid } from './SeatController.js';

let currentPage = 1;
const pageSize = 10;

export async function initPage(page = 1) {
    currentPage = page;
    const gridContainer = document.getElementById('events-grid');
    const paginationContainer = document.getElementById('pagination-container');
    
    try {
        const responseData = await fetchEvents(currentPage, pageSize);
        const eventsList = responseData.events ? responseData.events : responseData; 
        const totalPages = responseData.totalPages || 1;

        gridContainer.innerHTML = ''; 

        if (!eventsList || eventsList.length === 0) {
            gridContainer.innerHTML = '<div class="col-12 text-center text-muted">No hay eventos disponibles.</div>';
            if (paginationContainer) paginationContainer.innerHTML = '';
            return;
        }

        let cardsHtml = '';
        eventsList.forEach(event => { cardsHtml += createEventCard(event); });
        gridContainer.innerHTML = cardsHtml;

        attachButtonEvents();

        if (paginationContainer) {
            renderPagination(totalPages);
        }
    } catch (error) {
        console.error(error);
        gridContainer.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar el catálogo.</div>';
        if (paginationContainer) paginationContainer.innerHTML = '';
    }
}

function renderPagination(totalPages) {
    const container = document.getElementById('pagination-container');
    container.innerHTML = '';
    if (totalPages <= 1) return;

    const prevDisabled = currentPage === 1 ? 'disabled' : '';
    container.insertAdjacentHTML('beforeend', `
        <li class="page-item ${prevDisabled}">
            <button class="page-link bg-dark text-light border-secondary" onclick="changePage(${currentPage - 1})">Anterior</button>
        </li>
    `);

    for (let i = 1; i <= totalPages; i++) {
        const activeClass = i === currentPage ? 'active' : '';
        container.insertAdjacentHTML('beforeend', `
            <li class="page-item ${activeClass}">
                <button class="page-link ${i === currentPage ? 'bg-purple border-purple' : 'bg-dark text-light border-secondary'}" 
                        onclick="changePage(${i})">${i}</button>
            </li>
        `);
    }

    const nextDisabled = currentPage === totalPages ? 'disabled' : '';
    container.insertAdjacentHTML('beforeend', `
        <li class="page-item ${nextDisabled}">
            <button class="page-link bg-dark text-light border-secondary" onclick="changePage(${currentPage + 1})">Siguiente</button>
        </li>
    `);
}

window.changePage = (page) => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
    initPage(page);
};

function attachButtonEvents() {
    const viewCatalog = document.getElementById('view-catalog');
    const viewSectors = document.getElementById('view-sectors');
    const sectorsGrid = document.getElementById('sectors-grid');
    const buttons = document.querySelectorAll('.btn-select-seats');
    
    buttons.forEach(button => {
        button.addEventListener('click', async (e) => {
            const eventId = e.target.getAttribute('data-id');
            viewCatalog.classList.add('d-none');
            viewSectors.classList.remove('d-none');
            sectorsGrid.innerHTML = '<div class="col-12 text-center"><div class="spinner-border text-light" role="status"></div></div>';
            
            try {
                const responseData = await fetchSectorsByEvent(eventId);
                const sectorsList = responseData.sectors ? responseData.sectors : responseData;
                sectorsGrid.innerHTML = '';

                if (!sectorsList || sectorsList.length === 0) {
                    sectorsGrid.innerHTML = '<div class="col-12 text-center text-muted">No hay sectores disponibles.</div>';
                    return;
                }

                let sectorsHtml = '';
                sectorsList.forEach(sector => { sectorsHtml += createSectorCard(sector); });
                sectorsGrid.innerHTML = sectorsHtml;

                attachSectorButtonEvents();
            } catch (error) {
                sectorsGrid.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar sectores.</div>';
            }
        });
    });
}

function attachSectorButtonEvents() {
    const viewSectors = document.getElementById('view-sectors');
    const viewSeats = document.getElementById('view-seats');
    const seatMapTitle = document.getElementById('seat-map-title');
    const seatsGrid = document.getElementById('seats-grid');
    const btnViewSeats = document.querySelectorAll('.btn-view-seats');

    btnViewSeats.forEach(button => {
        button.addEventListener('click', async (e) => {
            const sectorId = e.target.getAttribute('data-sector-id');
            const sectorName = e.target.getAttribute('data-name');
            seatMapTitle.innerText = `Sector: ${sectorName}`;

            viewSectors.classList.add('d-none');
            viewSeats.classList.remove('d-none');

            seatsGrid.innerHTML = '<div class="text-center my-5"><div class="spinner-border spinner-neon" role="status"></div><p class="mt-2 text-muted">Armando el escenario...</p></div>';

            try {
                const responseData = await fetchSeatsBySector(sectorId);
                const seatsList = responseData.seats ? responseData.seats : responseData;
                
                if (!seatsList || seatsList.length === 0) {
                    seatsGrid.innerHTML = '<div class="text-center text-muted py-4">No hay butacas.</div>';
                    return;
                }
                
                renderSeatsGrid(seatsList, sectorId);
            } catch (error) {
                seatsGrid.innerHTML = '<div class="text-center text-danger py-4">Error al cargar el mapa.</div>';
            }
        });
    });
}