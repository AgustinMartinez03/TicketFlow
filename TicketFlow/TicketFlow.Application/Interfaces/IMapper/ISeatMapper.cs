using TicketFlow.Domain.Entities;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface ISeatMapper
    {
        IEnumerable<SeatResponse> MapToSeatResponseList(IEnumerable<Seat> seats);
    }
}