using Microsoft.Extensions.Logging;
using System;

namespace ServiceApplication.Application
{
    public class ServiceWorker : IServiceWorker, IDisposable
    {
        private readonly ILogger _logger;

        public ServiceWorker(ILogger<ServiceWorker> logger)
        {
            _logger = logger;
        }

        public void Dispose()
        {
            _logger.LogInformation("Calling Dispose on ServiceWorker");
        }

        public void DoWork()
        {
            _logger.LogInformation("ServiceWorker DoWork called");

            // Add logic here that service needs to perform
        } 
    }
}
