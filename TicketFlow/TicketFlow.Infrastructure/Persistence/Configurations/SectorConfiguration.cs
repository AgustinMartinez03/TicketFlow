using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class SectorConfiguration : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.ToTable("Sectors");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            // DATA SEEDING: 2 Sectores con distintas tarifas.
            builder.HasData(
                new Sector { Id = 1, EventId = 1, Name = "VIP", Price = 15000.00m, Capacity = 50 },
                new Sector { Id = 2, EventId = 1, Name = "General", Price = 5000.00m, Capacity = 50 }
            );
        }
    }
}
