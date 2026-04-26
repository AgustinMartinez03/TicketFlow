using TicketFlow.Domain.Entities;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface ISectorMapper
    {
        // Para transformar una lista de sectores
        IEnumerable<SectorResponse> MapToSectorResponseList(IEnumerable<Sector> sectors);
    }
}
