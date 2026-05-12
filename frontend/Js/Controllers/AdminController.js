import { createEventApi } from '../Services/EventService.js';
import { initPage } from './CatalogController.js';

export function setupAdminEvents() {
    const viewCatalog = document.getElementById('view-catalog');
    const viewCreateEvent = document.getElementById('view-create-event');
    const sectorsContainer = document.getElementById('sectors-container');

    document.getElementById('btn-nav-create-event').addEventListener('click', () => {
        viewCatalog.classList.add('d-none');
        viewCreateEvent.classList.remove('d-none');
        if (sectorsContainer.children.length === 0) {
            agregarFilaSector();
        }
    });

    document.getElementById('btn-back-catalog-from-admin').addEventListener('click', () => {
        viewCreateEvent.classList.add('d-none');
        viewCatalog.classList.remove('d-none');
    });

    document.getElementById('btn-add-sector').addEventListener('click', agregarFilaSector);

    document.getElementById('form-create-event').addEventListener('submit', async (e) => {
        e.preventDefault();

        const name = document.getElementById('event-name').value;
        const venue = document.getElementById('event-venue').value;
        const dateInput = document.getElementById('event-date').value;
        const formattedDate = new Date(dateInput).toISOString();
        
        const sectorsArray = [];
        const sectorEntries = document.querySelectorAll('.sector-entry');

        if (sectorEntries.length === 0) {
            Swal.fire({ 
                icon: 'warning', title: 'Atención', text: 'Debes agregar al menos un sector.',
                background: 'var(--card-bg)', color: 'var(--text-main)'
            });
            return;
        }

        sectorEntries.forEach(entry => {
            sectorsArray.push({
                name: entry.querySelector('.sector-name').value,
                price: parseFloat(entry.querySelector('.sector-price').value),
                capacity: parseInt(entry.querySelector('.sector-capacity').value)
            });
        });

        try {
            Swal.fire({
                title: 'Creando Evento...', background: 'var(--card-bg)', color: 'var(--text-main)',
                allowOutsideClick: false, didOpen: () => { Swal.showLoading(); }
            });

            await createEventApi({ name, venue, date: formattedDate, sectors: sectorsArray });

            Swal.fire({
                icon: 'success', title: '¡Evento Creado!', text: 'El evento está listo para recibir reservas.',
                background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--success)'
            });

            document.getElementById('form-create-event').reset();
            sectorsContainer.innerHTML = '';
            document.getElementById('btn-back-catalog-from-admin').click();
            initPage();
        } catch (error) {
            Swal.fire({
                icon: 'error', title: 'Error de creación', text: error.message,
                background: 'var(--card-bg)', color: 'var(--text-main)', confirmButtonColor: 'var(--danger)'
            });
        }
    });
}

function agregarFilaSector() {
    const sectorId = Date.now();
    const html = `
        <div class="row g-2 mb-3 sector-entry align-items-center" id="sector-row-${sectorId}">
            <div class="col-md-5">
                <input type="text" class="form-control text-white sector-name admin-input" placeholder="Nombre (ej: VIP)" required>
            </div>
            <div class="col-md-3">
                <input type="number" class="form-control text-white sector-price admin-input fw-normal" placeholder="Precio ($)" min="1" required>
            </div>
            <div class="col-md-3">
                <input type="number" class="form-control text-white sector-capacity admin-input" placeholder="Capacidad" min="1" required>
            </div>
            <div class="col-md-1">
                <button type="button" class="btn btn-outline-danger w-100" onclick="document.getElementById('sector-row-${sectorId}').remove()" title="Eliminar Sector">X</button>
            </div>
        </div>
    `;
    document.getElementById('sectors-container').insertAdjacentHTML('beforeend', html);
}