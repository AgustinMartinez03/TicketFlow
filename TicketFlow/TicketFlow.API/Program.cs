using Microsoft.EntityFrameworkCore;
using TicketFlow.API.Middlewares;
using TicketFlow.API.Workers;
using TicketFlow.Application.DTOs;
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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
            builder.Services.AddScoped<ILoginUseCase, LoginUseCase>();


            builder.Services.AddScoped<IPayReservationUseCase, PayReservationUseCase>();

            // Registrar el nuevo Caso de Uso
            builder.Services.AddScoped<ICancelExpiredReservationsUseCase, CancelExpiredReservationsUseCase>();

            // Registrar el Worker (Hosted Service)
            builder.Services.AddHostedService<ReservationCleanupWorker>();

            // 1. Creamos la instancia de JwtSettings y la llenamos con la sección "Jwt" del appsettings.json
            var jwtSettings = new JwtSettings();
            builder.Configuration.GetSection("Jwt").Bind(jwtSettings);

            // 2. Registramos el objeto como Singleton para que el LoginUseCase pueda recibirlo
            builder.Services.AddSingleton(jwtSettings);

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
                };
            });

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

            app.UseMiddleware<GlobalExceptionMiddleware>();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
