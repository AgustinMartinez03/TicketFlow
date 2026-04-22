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
                    newSector.Seats.Add(new Seat
                    {
                        Id = Guid.NewGuid(),
                        SectorId = newSector.Id,
                        RowIdentifier = "A", // Para simplificar, todas en la fila A por ahora
                        SeatNumber = i,
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