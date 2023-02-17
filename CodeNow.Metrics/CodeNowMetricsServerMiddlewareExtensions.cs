using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Prometheus;

namespace CodeNow.Metrics
{
    public static class CodeNowMetricsServerMiddlewareExtensions
    {
        /// <summary>
        /// Starts a Prometheus metrics exporter using endpoint routing.
        /// The default URL is /metrics, which is a Prometheus convention.
        /// Use static methods on the <see cref="T:Prometheus.Metrics" /> class to create your metrics.
        /// </summary>
        public static IEndpointConventionBuilder MapCodeNowsMetrics(
            this IEndpointRouteBuilder endpoints,
            string pattern = "/metrics")
        {
            return endpoints.MapMetrics(pattern);
        }
    }
}