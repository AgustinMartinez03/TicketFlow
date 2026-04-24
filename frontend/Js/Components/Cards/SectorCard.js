// Js/Components/Cards/SectorCard.js

export function createSectorCard(sector) {
    // Nota: Usamos fallbacks por si la API aún no devuelve capacity o price
    const capacityText = sector.capacity ? `${sector.capacity} Butacas Disponibles` : 'Ver disponibilidad';
    const priceText = sector.price ? `$${sector.price.toFixed(2)}` : 'Consultar precio';

    return `
        <div class="col-12 col-md-6 col-lg-4">
            <div class="card event-card h-100 rounded-3 overflow-hidden bg-transparent p-1">
                <div class="card-body d-flex flex-column">
                    <h4 class="card-title fw-bold text-white mb-3">${sector.name}</h4>
                    
                    <div class="d-flex align-items-center mb-2" style="color: var(--text-muted); font-size: 0.9rem;">
                        <span>🪑 ${capacityText}</span>
                    </div>
                    
                    <div class="d-flex align-items-center mb-4" style="color: var(--text-muted); font-size: 1.05rem;">
                        <span>💵 Desde <strong class="text-white">${priceText}</strong></span>
                    </div>
                    
                    <button class="btn btn-neon w-100 mt-auto btn-view-seats" data-sector-id="${sector.id}">
                        Ver Butacas
                    </button>
                </div>
            </div>
        </div>
    `;
}