using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Command
{
    public class ReservationCommand : IReservationCommand
    {
        private readonly AppDbContext _context;

        public ReservationCommand(AppDbContext context)
        {
            _context = context;
        }

        public void InsertReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
        }

        // 👇 IMPLEMENTAMOS LA NUEVA HERRAMIENTA
        public void UpdateReservation(Reservation reservation)
        {
            _context.Reservations.Update(reservation);
        }
    }
}