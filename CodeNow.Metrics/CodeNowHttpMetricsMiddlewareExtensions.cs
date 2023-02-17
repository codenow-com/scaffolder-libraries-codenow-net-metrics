using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Prometheus;

namespace CodeNow.Metrics
{
    /// <summary>
    /// Wrapper for prometheus-net.AspNetCoreMetrics
    /// </summary>
    public static class CodeNowHttpMetricsMiddlewareExtensions
    {
        /// <summary>
        /// Configures the ASP.NET Core request pipeline to collect Prometheus metrics on processed HTTP requests.
        /// 
        /// If using ASP.NET Core 3 or newer, call this after .UseRouting().
        /// </summary>
        public static IApplicationBuilder UseCodeNowHttpMetrics(
            this IApplicationBuilder app)
        {
            app.UseHttpMetrics();
            return app;
        }
    }
}