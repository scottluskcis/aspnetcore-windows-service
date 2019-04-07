using Microsoft.AspNetCore.Hosting;
using ServiceApplication.HostedServices;
using System.ServiceProcess;

namespace ServiceApplication.Extensions
{
    public static class WebHostServiceExtensions
    {
        public static void RunAsCustomService(this IWebHost host)
        {
            var webHostService = new CustomWebHostService(host);
            ServiceBase.Run(webHostService);
        }
    }
}
