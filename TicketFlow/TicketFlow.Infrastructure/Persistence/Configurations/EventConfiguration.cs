using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities; // Referencia a la capa Domain

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            // Nombre de la tabla
            builder.ToTable("Events");

            // Clave Primaria (PK)
            builder.HasKey(e => e.Id);

            // Propiedades y restricciones
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.EventDate)
                .IsRequired();

            builder.Property(e => e.Venue)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}