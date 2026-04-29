export function createSectorCard(sector) {
    return `
        <div class="col-12 col-md-6 col-lg-4 mb-4">
            <div class="card h-100 text-center sector-card overflow-hidden">
                <div class="card-header sector-header">
                    ${sector.name}
                </div>
                <div class="card-body d-flex flex-column justify-content-center p-4">
                    <h3 class="mb-3 sector-price">$${sector.price}</h3>
                    
                    <p class="mb-4 sector-info">
                        <i class="bi bi-people-fill me-2"></i>Capacidad: ${sector.capacity}
                    </p>
                    
                    <button class="btn w-100 mt-auto btn-view-seats btn-outline-neon" 
                            data-sector-id="${sector.id}" 
                            data-name="${sector.name}">
                        Elegir Asientos
                    </button>
                </div>
            </div>
        </div>
    `;
}