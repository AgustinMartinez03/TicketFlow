using TicketFlow.Application.DTOs.Response;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface IReservationMapper
    {
        List<UserReservationResponse> MapToUserReservationResponseList(IEnumerable<Reservation> reservations);
        PayReservationResponse MapToPayReservationResponse(List<Guid> reservationIds, string message, string status);
        ReserveSeatResponse MapToReserveSeatResponse(Reservation reservation, string message);
    }
}