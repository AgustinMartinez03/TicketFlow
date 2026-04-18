
using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IUseCase;
using TicketFlow.Application.UseCases;
using TicketFlow.Infrastructure.Command;
using TicketFlow.Infrastructure.Persistence;

namespace TicketFlow.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // 1. Configurar Entity Framework y SQL Server
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // 2. Inyección de Dependencias (Nuestras capas)
            // Scoped significa que se crea una instancia por cada petición HTTP
            builder.Services.AddScoped<IEventCommand, EventCommand>();
            builder.Services.AddScoped<ICreateEventUseCase, CreateEventUseCase>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
