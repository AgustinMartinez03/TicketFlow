// Js/Components/Cards/EventCard.js

export function createEventCard(event) {
    // Usamos una imagen genérica hermosa de Unsplash para los recitales
    const placeholderImage = "Assets/Images/placeholder.jpg";
    
    // Formatear la fecha (el backend devuelve 2026-12-20T20:00:00Z)
    const dateObj = new Date(event.eventDate);
    const dateStr = dateObj.toLocaleString('es-AR', { dateStyle: 'full', timeStyle: 'short' });

    // HTML de la tarjeta limpio y semántico
    return `
        <div class="col-12 col-md-6 col-lg-4">
            <div class="card event-card h-100 rounded-3 overflow-hidden">
                <img src="${placeholderImage}" class="card-img-top event-image" alt="${event.name}">
                
                <div class="card-body d-flex flex-column">
                    <h5 class="card-title event-title fw-bold mb-3">${event.name}</h5>
                    
                    <div class="d-flex align-items-center mb-2 event-info">
                        <span>📅 ${dateStr}</span>
                    </div>
                    
                    <div class="d-flex align-items-center mb-4 event-info">
                        <span>📍 ${event.venue}</span>
                    </div>
                    
                    <button class="btn btn-neon w-100 mt-auto btn-select-seats" data-id="${event.id}">
                        Ver Sectores
                    </button>
                </div>
            </div>
        </div>
    `;
}