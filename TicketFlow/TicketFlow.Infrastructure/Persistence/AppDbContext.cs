using Microsoft.EntityFrameworkCore;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Registra automáticamente todas las configuraciones de entidades definidas en el directorio "Configurations".
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}