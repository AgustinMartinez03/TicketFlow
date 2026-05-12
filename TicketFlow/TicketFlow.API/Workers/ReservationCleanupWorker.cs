using TicketFlow.Application.Interfaces.IUseCases;

namespace TicketFlow.API.Workers
{
    public class ReservationCleanupWorker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<ReservationCleanupWorker> _logger;

        public ReservationCleanupWorker(IServiceProvider serviceProvider, ILogger<ReservationCleanupWorker> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker de limpieza de reservas INICIADO.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
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

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}