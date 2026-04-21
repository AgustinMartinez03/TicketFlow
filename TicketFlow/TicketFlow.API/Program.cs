using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.UseCases;
using TicketFlow.Infrastructure.Command;
using TicketFlow.Infrastructure.Persistence;
using TicketFlow.Infrastructure.Querys;
using FluentValidation;
using TicketFlow.Application.Validators;
using TicketFlow.Application.DTOs.Request;

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
            builder.Services.AddScoped<IEventQuery, EventQuery>();
            builder.Services.AddScoped<IGetEventCatalogUseCase, GetEventCatalogUseCase>();
            builder.Services.AddScoped<ISeatQuery, SeatQuery>();
            builder.Services.AddScoped<IGetSeatsBySectorUseCase, GetSeatsBySectorUseCase>();
            builder.Services.AddScoped<ISeatCommand, SeatCommand>();
            builder.Services.AddScoped<IReserveSeatUseCase, ReserveSeatUseCase>();
            builder.Services.AddScoped<IReservationCommand, ReservationCommand>();
            builder.Services.AddScoped<IAuditLogCommand, AuditLogCommand>();

            builder.Services.AddScoped<IValidator<ReserveSeatRequest>, ReserveSeatRequestValidator>();

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
