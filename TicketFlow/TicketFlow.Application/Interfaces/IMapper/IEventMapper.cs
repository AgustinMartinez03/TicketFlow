using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlow.Application.DTOs.Request;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Application.Interfaces.IMapper
{
    public interface IEventMapper
    {
        Event CreateEvent(CreateEventRequest request);
    }
}
