using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Status)
                   .IsRequired()
                   .HasMaxLength(20);
            builder.Property(r => r.ReservedAt)
                   .IsRequired();
            builder.Property(r => r.ExpiresAt)
                   .IsRequired();

            // Relaciones (Foreign Keys)
            // Una reserva pertenece a un Usuario
            builder.HasOne(r => r.User)
                   .WithMany(u => u.Reservations)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Restrict); // Evita borrar un usuario si tiene reservas

            // Una reserva pertenece a una Butaca
            builder.HasOne(r => r.Seat)
                   .WithMany() // No pusimos lista de reservas en la clase Seat, lo cual está bien
                   .HasForeignKey(r => r.SeatId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}