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
        }
    }
}