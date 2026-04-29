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

            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(150);
            builder.Property(u => u.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Agustin",
                    Email = "agus@ticketflow.com",
                    PasswordHash = "123456"
                },
                new User
                {
                    Id = 2,
                    Name = "Alejandro",
                    Email = "ale@ticketflow.com",
                    PasswordHash = "123456"
                }
            );
        }
    }
}