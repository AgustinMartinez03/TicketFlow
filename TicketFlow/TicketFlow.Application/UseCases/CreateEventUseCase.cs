using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Exceptions; // Asegúrate de importar tus excepciones
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

        public async Task<CreateEventResponse> ExecuteAsync(CreateEventRequest request)
        {
            // --- 0. VALIDACIONES DE ENTRADA (Bad Request) ---

            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ExceptionBadRequest("El nombre del evento es obligatorio.");

            if (string.IsNullOrWhiteSpace(request.Venue))
                throw new ExceptionBadRequest("El lugar del evento es obligatorio.");

            if (request.Date <= DateTime.Now)
                throw new ExceptionBadRequest("La fecha del evento debe ser en el futuro.");

            if (request.Sectors == null || !request.Sectors.Any())
                throw new ExceptionBadRequest("Debe incluir al menos un sector para el evento.");

            // 1. Instanciar el Evento
            var newEvent = new Event
            {
                Name = request.Name,
                Venue = request.Venue,
                EventDate = request.Date,
                Sectors = new List<Sector>()
            };

            // 2. Procesar los sectores
            foreach (var sectorReq in request.Sectors)
            {
                // Validaciones por sector
                if (string.IsNullOrWhiteSpace(sectorReq.Name))
                    throw new ExceptionBadRequest("El nombre de cada sector es obligatorio.");

                if (sectorReq.Price <= 0)
                    throw new ExceptionBadRequest($"El precio del sector '{sectorReq.Name}' debe ser mayor a 0.");

                if (sectorReq.Capacity <= 0 || sectorReq.Capacity > 100)
                    throw new ExceptionBadRequest($"La capacidad del sector '{sectorReq.Name}' debe estar entre 1 y 100.");

                var newSector = new Sector
                {
                    Name = sectorReq.Name,
                    Price = sectorReq.Price,
                    Capacity = sectorReq.Capacity,
                    Seats = new List<Seat>()
                };

                // 3. Generar automáticamente las butacas
                for (int i = 1; i <= sectorReq.Capacity; i++)
                {
                    int rowIndex = (i - 1) / 10;
                    string rowIdentifier = ((char)('A' + rowIndex)).ToString();
                    int seatNumberInRow = ((i - 1) % 10) + 1;

                    newSector.Seats.Add(new Seat
                    {
                        Id = Guid.NewGuid(),
                        RowIdentifier = rowIdentifier,
                        SeatNumber = seatNumberInRow,
                        Status = "Available"
                    });
                }

                newEvent.Sectors.Add(newSector);
            }

            // 4. Guardar todo en cascada
            await _eventCommand.InsertEventAsync(newEvent);
            await _eventCommand.SaveChangesAsync();

            return new CreateEventResponse
            {
                Id = newEvent.Id,
                Message = "Evento creado exitosamente con sus sectores y butacas."
            };
        }
    }
}