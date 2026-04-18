using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("Seats");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.RowIdentifier)
                   .IsRequired()
                   .HasMaxLength(5);

            builder.Property(s => s.Status)
                   .IsRequired()
                   .HasMaxLength(20);

            // Configuración de Concurrencia (Fase 2)
            builder.Property(s => s.Version).IsConcurrencyToken();

            // DATA SEEDING: 50 Butacas por sector
            var seats = new List<Seat>();

            // Generar 50 butacas para el Sector 1 (VIP)
            for (int i = 1; i <= 50; i++)
            {
                seats.Add(new Seat
                {
                    Id = Guid.NewGuid(),
                    SectorId = 1,
                    RowIdentifier = "A",
                    SeatNumber = i,
                    Status = "Available",
                    Version = 1
                });
            }

            // Generar 50 butacas para el Sector 2 (General)
            for (int i = 1; i <= 50; i++)
            {
                seats.Add(new Seat
                {
                    Id = Guid.NewGuid(),
                    SectorId = 2,
                    RowIdentifier = "B",
                    SeatNumber = i,
                    Status = "Available",
                    Version = 1
                });
            }

            builder.HasData(seats);
        }
    }
}