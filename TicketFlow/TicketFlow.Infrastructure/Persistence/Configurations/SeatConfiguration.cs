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

            builder.Property(s => s.Version)
                   .IsConcurrencyToken();

            var seats = new List<Seat>();

            int cantidadFilas = 5;
            int butacasPorFila = 10;

            int[] sectorIds = new int[] { 1, 2 };

            foreach (int sectorId in sectorIds)
            {
                for (int f = 0; f < cantidadFilas; f++)
                {
                    string rowIdentifier = ((char)('A' + f)).ToString();

                    for (int numero = 1; numero <= butacasPorFila; numero++)
                    {
                        seats.Add(new Seat
                        {
                            Id = Guid.NewGuid(),
                            SectorId = sectorId,
                            RowIdentifier = rowIdentifier,
                            SeatNumber = numero,
                            Status = "Available",
                            Version = 1
                        });
                    }
                }
            }

            builder.HasData(seats);
        }
    }
}