import { fetchEvents } from '../Services/EventService.js';
import { createEventCard } from '../Components/Cards/EventCard.js';
import { fetchSectorsByEvent } from '../Services/SectorService.js';
import { createSectorCard } from '../Components/Cards/SectorCard.js';
import { fetchSeatsBySector, reserveSeatApi } from '../Services/SeatService.js';

const viewCatalog = document.getElementById('view-catalog');
const viewSectors = document.getElementById('view-sectors');
const sectorsGrid = document.getElementById('sectors-grid');
const viewSeats = document.getElementById('view-seats');
const seatsGrid = document.getElementById('seats-grid');
const seatMapTitle = document.getElementById('seat-map-title');

async function initPage() {
    const gridContainer = document.getElementById('events-grid');
    
    try {
        const responseData = await fetchEvents();
        
        const eventsList = responseData.events ? responseData.events : responseData; 

        gridContainer.innerHTML = ''; 

        if (!eventsList || eventsList.length === 0) {
            gridContainer.innerHTML = '<div class="col-12 text-center text-muted">No hay eventos disponibles.</div>';
            return;
        }

        let cardsHtml = '';
        eventsList.forEach(event => {
            cardsHtml += createEventCard(event);
        });
        gridContainer.innerHTML = cardsHtml;

        attachButtonEvents();

    } catch (error) {
        console.error("Error real capturado:", error);
        gridContainer.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar el catálogo.</div>';
    }
}

function attachButtonEvents() {
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
                    sectorsGrid.innerHTML = '<div class="col-12 text-center text-muted">No hay sectores disponibles para este evento.</div>';
                    return;
                }

                let sectorsHtml = '';
                sectorsList.forEach(sector => {
                    sectorsHtml += createSectorCard(sector);
                });
                sectorsGrid.innerHTML = sectorsHtml;

                attachSectorButtonEvents();

            } catch (error) {
                console.error(error);
                sectorsGrid.innerHTML = '<div class="col-12 text-center text-danger">Error al cargar sectores.</div>';
            }
        });
    });
}

document.getElementById('btn-back-catalog').addEventListener('click', () => {
    viewSectors.classList.add('d-none');
    viewCatalog.classList.remove('d-none');
});

function attachSectorButtonEvents() {
    const btnViewSeats = document.querySelectorAll('.btn-view-seats');

    btnViewSeats.forEach(button => {
        button.addEventListener('click', async (e) => {
            const sectorId = e.target.getAttribute('data-sector-id');

            const sectorName = e.target.getAttribute('data-name');
            seatMapTitle.innerText = `Sector: ${sectorName}`;

            viewSectors.classList.add('d-none');
            viewSeats.classList.remove('d-none');

            seatsGrid.innerHTML = '<div class="text-center my-5"><div class="spinner-border" style="color: var(--neon-purple);" role="status"></div><p class="mt-2 text-muted">Armando el escenario...</p></div>';

            try {
                const responseData = await fetchSeatsBySector(sectorId);
                const seatsList = responseData.seats ? responseData.seats : responseData;
                
                if (!seatsList || seatsList.length === 0) {
                    seatsGrid.innerHTML = '<div class="text-center text-muted py-4">No hay butacas configuradas para este sector.</div>';
                    return;
                }
                
                renderSeatsGrid(seatsList);

            } catch (error) {
                console.error(error);
                seatsGrid.innerHTML = '<div class="text-center text-danger py-4">Error al cargar el mapa de butacas.</div>';
            }
        });
    });
}

function renderSeatsGrid(seatsList) {
    const rows = {};
    seatsList.forEach(seat => {
        if (!rows[seat.rowIdentifier]) rows[seat.rowIdentifier] = [];
        rows[seat.rowIdentifier].push(seat);
    });

    let html = '';

    Object.keys(rows).sort().forEach(rowKey => {
        const seatsInRow = rows[rowKey];
        seatsInRow.sort((a, b) => a.seatNumber - b.seatNumber);

        html += `
            <div class="d-flex align-items-center mb-2 seat-row">
                <div class="row-label">${rowKey}</div>
                <div class="d-flex gap-2 flex-nowrap flex-grow-1 justify-content-center">
        `;

        seatsInRow.forEach(seat => {
            let statusClass = '';
            let disabledClass = '';

            if (seat.status === 'Available') {
                statusClass = 'seat-available';
            } else if (seat.status === 'Reserved') {
                statusClass = 'seat-reserved';
                disabledClass = 'disabled';
            } else {
                statusClass = 'seat-sold';
                disabledClass = 'disabled';
            }

            html += `
                <button class="btn btn-sm seat-btn ${statusClass} ${disabledClass}"
                        data-seat-id="${seat.id}"
                        data-seat-row="${seat.rowIdentifier}"
                        data-seat-number="${seat.seatNumber}"
                        title="Fila ${seat.rowIdentifier} - Butaca ${seat.seatNumber}">
                    ${seat.seatNumber}
                </button>
            `;
        });

        html += `
                </div>
                <div class="row-label text-end">${rowKey}</div>
            </div>
        `;
    });

    seatsGrid.innerHTML = html;
    attachSeatClickEvents();
}

function attachSeatClickEvents() {
    const availableSeats = document.querySelectorAll('.seat-btn:not(.disabled)');
    
    availableSeats.forEach(seatBtn => {
        seatBtn.addEventListener('click', (e) => {

            if (seatBtn.classList.contains('disabled')) {
                return; 
            }

            const seatId = e.target.getAttribute('data-seat-id');
            const row = e.target.getAttribute('data-seat-row');
            const number = e.target.getAttribute('data-seat-number');

            Swal.fire({
                title: '¿Confirmar Reserva?',
                text: `Estás por seleccionar la Fila ${row}, Butaca ${number}. ¿Deseas continuar?`,
                icon: 'question',
                showCancelButton: true,
                confirmButtonColor: '#8b5cf6',
                cancelButtonColor: '#3f3f46',
                confirmButtonText: 'Sí, reservar',
                cancelButtonText: 'Cancelar',
                background: '#1a1d24',
                color: '#ffffff'
            }).then(async(result) => {
                
                if (result.isConfirmed) {
                    
                    Swal.fire({
                        title: 'Procesando reserva...',
                        text: 'Por favor aguardá un instante.',
                        background: '#1a1d24',
                        color: '#ffffff',
                        allowOutsideClick: false,
                        didOpen: () => {
                            Swal.showLoading();
                        }
                    });

                    try {
                        const dummyUserId = "1";
                        
                        await reserveSeatApi(seatId, dummyUserId);
                        
                        seatBtn.classList.remove('seat-available');
                        seatBtn.classList.add('disabled', 'seat-reserved');

                        await Swal.fire({
                            title: '¡Reserva Confirmada!',
                            text: `Tu butaca ha sido reservada con éxito.`,
                            icon: 'success',
                            background: '#1a1d24',
                            color: '#ffffff',
                            confirmButtonColor: '#10b981'
                        });

                    } catch (error) {
                        Swal.fire({
                            title: '¡Ups!',
                            text: error.message || 'No se pudo completar la reserva.',
                            icon: 'error',
                            background: '#1a1d24',
                            color: '#ffffff',
                            confirmButtonColor: '#ef4444'
                        });
                    }
                }
            });
        });
    });
}

document.getElementById('btn-back-sectors').addEventListener('click', () => {
    viewSeats.classList.add('d-none');
    viewSectors.classList.remove('d-none');
});

initPage();