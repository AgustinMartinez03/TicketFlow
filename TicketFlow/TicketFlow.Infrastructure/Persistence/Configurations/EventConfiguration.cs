using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

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

            builder.HasData(
                new Event
                {
                    Id = 1,
                    Name = "Concierto de Rock Universitario",
                    EventDate = new DateTime(2026, 10, 15, 20, 0, 0),
                    Venue = "Estadio UNAJ",
                    Status = "Active"
                }
            );
        }
    }
}