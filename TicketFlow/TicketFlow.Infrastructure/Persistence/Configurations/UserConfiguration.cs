using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            // Restricciones de tamaño para optimizar la base de datos
            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(150);
            builder.Property(u => u.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(255);

            // Indice único: No pueden existir dos usuarios con el mismo email
            builder.HasIndex(u => u.Email).IsUnique();
        }
    }
}