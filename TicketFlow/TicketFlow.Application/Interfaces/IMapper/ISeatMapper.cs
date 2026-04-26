using TicketFlow.Domain.Entities;
using TicketFlow.Application.DTOs.Response;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface ISeatMapper
    {
        // Usamos IEnumerable como parámetro de entrada para evitar el error anterior
        IEnumerable<SeatResponse> MapToSeatResponseList(IEnumerable<Seat> seats);
    }
}