// Js/Components/Cards/EventCard.js

export function createEventCard(event) {
    // Usamos una imagen genérica hermosa de Unsplash para los recitales
    const placeholderImage = "https://images.unsplash.com/photo-1514320291840-2e0a9bf2a9ae?auto=format&fit=crop&w=800&q=80";
    
    // Formatear la fecha (el backend devuelve 2026-12-20T20:00:00Z)
    const dateObj = new Date(event.eventDate);
    const dateStr = dateObj.toLocaleString('es-AR', { dateStyle: 'full', timeStyle: 'short' });

    // HTML de la tarjeta usando la grilla de Bootstrap (col-md-6 col-lg-4)
    return `
        <div class="col-12 col-md-6 col-lg-4">
            <div class="card event-card h-100 rounded-3 overflow-hidden">
                <img src="${placeholderImage}" class="card-img-top" alt="${event.name}" style="aspect-ratio: 16/10; object-fit: cover;">
                <div class="card-body d-flex flex-column">
                    <h5 class="card-title fw-bold mb-3" style="color: var(--text-main)">${event.name}</h5>
                    
                    <div class="d-flex align-items-center mb-2" style="color: var(--text-muted); font-size: 0.9rem;">
                        <span>📅 ${dateStr}</span>
                    </div>
                    
                    <div class="d-flex align-items-center mb-4" style="color: var(--text-muted); font-size: 0.9rem;">
                        <span>📍 ${event.venue}</span>
                    </div>
                    
                    <button class="btn btn-neon w-100 mt-auto btn-select-seats" data-id="${event.id}">
                        Seleccionar Butacas
                    </button>
                </div>
            </div>
        </div>
    `;
}