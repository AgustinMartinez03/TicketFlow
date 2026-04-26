using TicketFlow.Domain.Entities;
using TicketFlow.Application.DTOs.Response;
using TicketFlow.Application.Interfaces.IMapper;

namespace TicketFlow.Application.Mapper
{
    public class SectorMapper : ISectorMapper
    {
        public IEnumerable<SectorResponse> MapToSectorResponseList(IEnumerable<Sector> sectors)
        {
            return sectors.Select(s => new SectorResponse
            {
                Id = s.Id,
                Name = s.Name,
                Price = s.Price,
                Capacity = s.Capacity
            }).ToList();
        }
    }
}
