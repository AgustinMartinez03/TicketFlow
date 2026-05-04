using TicketFlow.Application.DTOs.Response;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface IReservationMapper
    {
        List<UserReservationResponse> MapToUserReservationResponseList(IEnumerable<Reservation> reservations);
        PayReservationResponse MapToPayReservationResponse(Reservation reservation, string message);
        ReserveSeatResponse MapToReserveSeatResponse(Reservation reservation, string message);
    }
}