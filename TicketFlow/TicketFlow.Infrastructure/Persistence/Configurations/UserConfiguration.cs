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

            builder.Property(u => u.Role)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(u => u.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin General",
                    Email = "admin@ticketflow.com",
                    PasswordHash = "$2a$12$eQQOCJVOpp0NS8MJ0C5c1Oo6gbsC58uD.j6wZE9Z6xnzfMsRd1H6G",
                    Role = "Admin"
                },
                new User
                {
                    Id = 2,
                    Name = "Alejandro",
                    Email = "ale@ticketflow.com",
                    PasswordHash = "$2a$12$WQUmKUbkI6C6a2e5nDxfvO42I5fVVOnVlE1JnYAWXGP914Cs4RMPC",
                    Role = "Client"
                },
                new User
                {
                    Id = 3,
                    Name = "Agustin",
                    Email = "agus@ticketflow.com",
                    PasswordHash = "$2a$12$aJGDFO5wFcTycwlLZ1XfFepllyAhVEawY/pOPvmZKnUcf/BEHlDqy",
                    Role = "Client"
                }
            );
        }
    }
}