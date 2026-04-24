using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Mapper
{
    public class EventMapper : IEventMapper
    {
        public Event CreateEvent(CreateEventRequest request)
        {
            return new Event
            {
                Name = request.Name,
                Venue = request.Venue,
                EventDate = request.Date,
                Sectors = new List<Sector>()
            };
        }
    }
}
