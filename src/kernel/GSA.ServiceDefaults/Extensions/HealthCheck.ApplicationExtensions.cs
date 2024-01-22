using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;

namespace GSA.ServiceDefaults.Extensions;

public static partial class ApplicationExtensions
{
    private static readonly string[] HEALTHY_STATE_TAGS = ["live"];
    private const string HEALTH_CHECK_ROUTE = "/app-health";
    private const string APP_HEALTH_CHECK_NAME = "self";

    public static IHostApplicationBuilder AddApplicationHealthCheck(this IHostApplicationBuilder appBuilder)
    {
        appBuilder.Services.AddHealthChecks().AddCheck(APP_HEALTH_CHECK_NAME, () => HealthCheckResult.Healthy(), HEALTHY_STATE_TAGS);

        return appBuilder;
    }

    public static WebApplication MapHealthCheckEndpoints(this WebApplication webApp)
    {
        webApp.MapHealthChecks(HEALTH_CHECK_ROUTE, new HealthCheckOptions
        {
            Predicate = healthCheck => healthCheck.Tags.All(tag => HEALTHY_STATE_TAGS.Contains(tag))
        });

        return webApp;
    }
}
