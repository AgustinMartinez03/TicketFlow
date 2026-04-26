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

            // DATA SEEDING: 50 Butacas por sector (5 Filas de 10 butacas cada una)
            var seats = new List<Seat>();

            int cantidadFilas = 5;    // 5 filas (A, B, C, D, E)
            int butacasPorFila = 10;  // 10 butacas por fila (Total: 50 butacas por sector)

            // Los IDs de los 2 sectores que ya tenés creados
            int[] sectorIds = new int[] { 1, 2 };

            foreach (int sectorId in sectorIds)
            {
                // Bucle para las letras (Filas)
                for (int f = 0; f < cantidadFilas; f++)
                {
                    // Convertimos el índice 0, 1, 2... en letra A, B, C...
                    string rowIdentifier = ((char)('A' + f)).ToString();

                    // Bucle para los números (Butacas)
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