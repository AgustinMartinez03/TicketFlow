using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Workers
{
    public class ReservationCleanupWorker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<ReservationCleanupWorker> _logger;

        // Inyectamos IServiceProvider porque los BackgroundService son "Singleton" (viven siempre),
        // pero nuestro Caso de Uso es "Scoped" (vive por petición). Necesitamos crear un Scope manual.
        public ReservationCleanupWorker(IServiceProvider serviceProvider, ILogger<ReservationCleanupWorker> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("🚀 Worker de limpieza de reservas INICIADO.");

            // El loop infinito que corre mientras la API esté viva
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // Creamos un "Scope" (como si fuera una petición HTTP fantasma)
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var cancelUseCase = scope.ServiceProvider.GetRequiredService<ICancelExpiredReservationsUseCase>();
                        await cancelUseCase.ExecuteAsync();
                    }

                    _logger.LogInformation($"[{DateTime.UtcNow:HH:mm:ss}] Worker revisó reservas expiradas.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Ocurrió un error al limpiar las reservas.");
                }

                // Dormimos el worker por 1 minuto antes de volver a revisar
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}