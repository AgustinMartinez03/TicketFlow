using TicketFlow.Domain.Entities;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;

namespace TicketFlow.Application.Mapper
{
    public class SeatMapper : ISeatMapper
    {
        public IEnumerable<SeatResponse> MapToSeatResponseList(IEnumerable<Seat> seats)
        {
            return seats.Select(s => new SeatResponse
            {
                Id = s.Id,
                RowIdentifier = s.RowIdentifier,
                SeatNumber = s.SeatNumber,
                Status = s.Status
            }).ToList();
        }
    }
}