using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketFlow.Domain.Entities;

namespace TicketFlow.Infrastructure.Persistence.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.ToTable("AuditLogs");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Action)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(a => a.EntityType)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(a => a.EntityId)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(a => a.Details)
                   .IsRequired(); // Sin límite, puede ser un texto largo (JSON)
            builder.Property(a => a.CreatedAt)
                   .IsRequired();

            // Configuración de la Clave Foránea opcional
            builder.HasOne(a => a.User)
                   .WithMany() // Un usuario puede tener muchos logs, pero no navegamos desde User a Logs
                   .HasForeignKey(a => a.UserId)
                   .IsRequired(false) // Esto hace que en SQL la columna acepte NULL
                   .OnDelete(DeleteBehavior.SetNull); // Si se borra un usuario, el log queda, pero con UserId en NULL
        }
    }
}