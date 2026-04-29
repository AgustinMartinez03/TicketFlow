using TicketFlow.Domain.Entities;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface ISectorMapper
    {
        IEnumerable<SectorResponse> MapToSectorResponseList(IEnumerable<Sector> sectors);
    }
}
