using Microsoft.Extensions.Logging;

namespace ServiceApplication.Application
{
    public class ServiceWorker : IServiceWorker
    {
        private readonly ILogger _logger;

        public ServiceWorker(ILogger<ServiceWorker> logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.LogInformation("ServiceWorker DoWork called");
        } 
    }
}
