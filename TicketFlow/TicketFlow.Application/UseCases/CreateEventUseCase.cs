using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.UseCases
{
    public class CreateEventUseCase : ICreateEventUseCase
    {
        private readonly IEventCommand _eventCommand;

        public CreateEventUseCase(IEventCommand eventCommand)
        {
            _eventCommand = eventCommand;
        }

        public async Task<int> ExecuteAsync(CreateEventRequest request)
        {
            // 1. Instanciar el Evento
            var newEvent = new Event
            {
                Name = request.Name,
                Venue = request.Venue,
                EventDate = request.Date,
                Sectors = new List<Sector>()
            };

            // 2. Procesar los sectores que pidió el administrador
            foreach (var sectorReq in request.Sectors)
            {
                var newSector = new Sector
                {
                    EventId = newEvent.Id,
                    Name = sectorReq.Name,
                    Price = sectorReq.Price,
                    Capacity = sectorReq.Capacity,
                    Seats = new List<Seat>()
                };

                // 3. ¡Magia! Generar automáticamente las butacas para este sector
                for (int i = 1; i <= sectorReq.Capacity; i++)
                {
                    // Calculamos el índice de la fila (0 para los asientos 1-10, 1 para 11-20, etc.)
                    int rowIndex = (i - 1) / 10;

                    // Convertimos el índice a letra (0 -> A, 1 -> B, 2 -> C...)
                    string rowIdentifier = ((char)('A' + rowIndex)).ToString();

                    // Calculamos el número de asiento relativo a su fila (del 1 al 10)
                    int seatNumberInRow = ((i - 1) % 10) + 1;

                    newSector.Seats.Add(new Seat
                    {
                        Id = Guid.NewGuid(),
                        SectorId = newSector.Id,
                        RowIdentifier = rowIdentifier,
                        SeatNumber = seatNumberInRow,
                        Status = "Available"
                    });
                }

                newEvent.Sectors.Add(newSector);
            }

            // 4. Guardar todo en cascada (EF Core es lo suficientemente inteligente para guardar Evento, Sectores y Butacas juntos)
            await _eventCommand.InsertEventAsync(newEvent);
            await _eventCommand.SaveChangesAsync();

            return newEvent.Id;
        }
    }
}