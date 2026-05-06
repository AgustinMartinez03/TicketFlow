export function createSeatsGridHtml(seatsList, sectorId, miReservaActual) {
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
                const esMia = miReservaActual && miReservaActual.seatId === seat.id;
                if (esMia) {
                    statusClass = 'seat-my-reserved'; 
                    disabledClass = '';
                } else {
                    statusClass = 'seat-reserved';
                    disabledClass = 'disabled'; 
                }
            } else {
                statusClass = 'seat-sold';
                disabledClass = 'disabled';
            }

            html += `
                <button class="btn btn-sm seat-btn ${statusClass} ${disabledClass}"
                        data-seat-id="${seat.id}"
                        data-seat-row="${seat.rowIdentifier}"
                        data-seat-number="${seat.seatNumber}"
                        data-sector-id="${sectorId}"
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

    return html;
}