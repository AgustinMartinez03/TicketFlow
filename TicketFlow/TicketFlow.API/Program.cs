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

            // ==========================================
            // 1. CONFIGURACIÓN BASE (Base de Datos)
            // ==========================================
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // ==========================================
            // 2. DOMINIO: AUTH & USERS (Usuarios y Login)
            // ==========================================
            builder.Services.AddScoped<IUserQuery, UserQuery>();
            builder.Services.AddScoped<ILoginMapper, LoginMapper>();
            builder.Services.AddScoped<ILoginUseCase, LoginUseCase>();

            // ==========================================
            // 3. DOMINIO: EVENTS (Eventos)
            // ==========================================
            builder.Services.AddScoped<IEventCommand, EventCommand>();
            builder.Services.AddScoped<IEventQuery, EventQuery>();
            builder.Services.AddScoped<IEventMapper, EventMapper>();
            builder.Services.AddScoped<ICreateEventUseCase, CreateEventUseCase>();
            builder.Services.AddScoped<IGetEventCatalogUseCase, GetEventCatalogUseCase>();

            // ==========================================
            // 4. DOMINIO: SECTORS (Sectores)
            // ==========================================
            builder.Services.AddScoped<ISectorQuery, SectorQuery>();
            builder.Services.AddScoped<ISectorMapper, SectorMapper>();
            builder.Services.AddScoped<IGetSectorsByEventUseCase, GetSectorsByEventUseCase>();

            // ==========================================
            // 5. DOMINIO: SEATS (Butacas)
            // ==========================================
            builder.Services.AddScoped<ISeatCommand, SeatCommand>();
            builder.Services.AddScoped<ISeatQuery, SeatQuery>();
            builder.Services.AddScoped<ISeatMapper, SeatMapper>();
            builder.Services.AddScoped<IGetSeatsBySectorUseCase, GetSeatsBySectorUseCase>();

            // ==========================================
            // 6. DOMINIO: RESERVATIONS & PAYMENTS (Reservas y Pagos)
            // ==========================================
            builder.Services.AddScoped<IReservationCommand, ReservationCommand>();
            builder.Services.AddScoped<IReservationQuery, ReservationQuery>();
            builder.Services.AddScoped<IReservationMapper, ReservationMapper>();
            builder.Services.AddScoped<IReserveSeatUseCase, ReserveSeatUseCase>();
            builder.Services.AddScoped<IPayReservationUseCase, PayReservationUseCase>();
            builder.Services.AddScoped<IGetUserReservationsUseCase, GetUserReservationsUseCase>();
            builder.Services.AddScoped<ICancelExpiredReservationsUseCase, CancelExpiredReservationsUseCase>();

            // ==========================================
            // 7. DOMINIO: AUDIT (Auditoría del Sistema)
            // ==========================================
            builder.Services.AddScoped<IAuditLogCommand, AuditLogCommand>();

            // ==========================================
            // 8. BACKGROUND SERVICES (Workers)
            // ==========================================
            builder.Services.AddHostedService<ReservationCleanupWorker>();


            // ==========================================
            // 9. CONFIGURACIÓN DE RUTAS Y CONTROLADORES
            // ==========================================
            // Forzar que todas las URLs generadas y expuestas en Swagger sean en minúsculas (Buena práctica SEO/API)
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();

            // ==========================================
            // 10. SEGURIDAD: CORS (Cross-Origin Resource Sharing)
            // ==========================================
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            // ==========================================
            // 11. SEGURIDAD: AUTENTICACIÓN (JWT) Y AUTORIZACIÓN
            // ==========================================
            var jwtSettings = new JwtSettings();
            builder.Configuration.GetSection("Jwt").Bind(jwtSettings);

            // Registramos el objeto como Singleton para que el LoginUseCase u otros puedan inyectarlo
            builder.Services.AddSingleton(jwtSettings);

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
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

            builder.Services.AddAuthorization();

            // ==========================================
            // 12. DOCUMENTACIÓN API (Swagger)
            // ==========================================
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // ==========================================
            //  CONSTRUCCIÓN DE LA APLICACIÓN (BUILD)
            // ==========================================
            var app = builder.Build();

            // ==========================================
            // 13. PIPELINE HTTP (MIDDLEWARES)
            // ==========================================
            app.UseMiddleware<GlobalExceptionMiddleware>();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
