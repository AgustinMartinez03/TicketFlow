using Microsoft.EntityFrameworkCore;
using TicketFlow.Application.Interfaces.ICommands;
using TicketFlow.Application.Interfaces.IMapper;
using TicketFlow.Application.Interfaces.IQuerys;
using TicketFlow.Application.Interfaces.IUseCases;
using TicketFlow.Application.Mapper;
using TicketFlow.Application.UseCases;
using TicketFlow.Infrastructure.Command;
using TicketFlow.Infrastructure.Persistence;
using TicketFlow.Infrastructure.Query;
using TicketFlow.Infrastructure.Querys;

namespace TicketFlow.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IEventCommand, EventCommand>();
            builder.Services.AddScoped<IEventMapper, EventMapper>();
            builder.Services.AddScoped<IEventQuery, EventQuery>();
            builder.Services.AddScoped<ICreateEventUseCase, CreateEventUseCase>();
            builder.Services.AddScoped<IGetEventCatalogUseCase, GetEventCatalogUseCase>();

            builder.Services.AddScoped<ISeatQuery, SeatQuery>();
            builder.Services.AddScoped<ISeatMapper, SeatMapper>();
            builder.Services.AddScoped<IGetSeatsBySectorUseCase, GetSeatsBySectorUseCase>();
            builder.Services.AddScoped<ISeatCommand, SeatCommand>();
            builder.Services.AddScoped<IReserveSeatUseCase, ReserveSeatUseCase>();

            builder.Services.AddScoped<IReservationCommand, ReservationCommand>();
            builder.Services.AddScoped<IReservationMapper, ReservationMapper>();
            builder.Services.AddScoped<IAuditLogCommand, AuditLogCommand>();
            builder.Services.AddScoped<IReservationQuery, ReservationQuery>();
            builder.Services.AddScoped<IGetUserReservationsUseCase, GetUserReservationsUseCase>();

            builder.Services.AddScoped<ISectorQuery, SectorQuery>();
            builder.Services.AddScoped<ISectorMapper, SectorMapper>();
            builder.Services.AddScoped<IGetSectorsByEventUseCase, GetSectorsByEventUseCase>();

            builder.Services.AddScoped<IUserQuery, UserQuery>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            // Forzar que todas las URLs generadas y expuestas en Swagger sean en minúsculas
            builder.Services.AddRouting(options => options.LowercaseUrls = true);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
