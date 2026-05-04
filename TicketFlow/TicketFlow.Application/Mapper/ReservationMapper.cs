using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Mapper
{
    public class ReservationMapper : IReservationMapper
    {
        public List<UserReservationResponse> MapToUserReservationResponseList(IEnumerable<Reservation> reservations)
        {
            return reservations.Select(r => new UserReservationResponse
            {
                ReservationId = r.Id,
                EventName = r.Seat.Sector.Event.Name,
                EventDate = r.Seat.Sector.Event.EventDate,
                Venue = r.Seat.Sector.Event.Venue,
                SectorName = r.Seat.Sector.Name,
                SeatDetails = $"Fila {r.Seat.RowIdentifier} - Asiento {r.Seat.SeatNumber}",
                Status = r.Status
            }).ToList();
        }

        public PayReservationResponse MapToPayReservationResponse(Reservation reservation, string message)
        {
            return new PayReservationResponse
            {
                ReservationId = reservation.Id,
                Status = "Completed",
                Message = message
            };
        }

        public ReserveSeatResponse MapToReserveSeatResponse(Reservation reservation, string message)
        {
            return new ReserveSeatResponse
            {
                ReservationId = reservation.Id,
                Message = message
            };
        }
    }
}