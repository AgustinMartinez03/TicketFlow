using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.Exceptions;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Domain.Entities;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.Infrastructure.Command
{
    public class SeatCommand : ISeatCommand
    {
        private readonly AppDbContext _context;

        public SeatCommand(AppDbContext context)
        {
            _context = context;
        }

        public void UpdateSeat(Seat seat)
        {
            _context.Seats.Update(seat);
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Acá traducimos el error de EF Core a un error puro de nuestra arquitectura
                throw new ExceptionConcurrency("Colisión de concurrencia en la base de datos.");
            }
        }

        public void DiscardChanges()
        {
            // Esto borra toda la basura que quedó trabada (la butaca rota y la reserva a medias)
            _context.ChangeTracker.Clear();
        }
    }
}