using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GSA.ServiceDefaults.Extensions;

public static partial class WebApplicationExtensions
{
    public static IHostApplicationBuilder AddWebApplicationExtensions(this IHostApplicationBuilder builder)
    {
        builder.AddOpenAPIDocumentation();

        builder.AddApplicationHealthCheck();

        builder.AddApplicationLogging();

        builder.ConfigureOpenTelemetry();

        builder.Services.AddServiceDiscovery();

        builder.Services.ConfigureHttpClientDefaults(options =>
        {
            // Turn on resilience by default
            options.AddStandardResilienceHandler();

            // Turn on service discovery by default
            options.UseServiceDiscovery();
        });

        return builder;
    }

    public static WebApplication UseWebApplicationExtensions(this WebApplication webApplication)
    {
        webApplication.UseOpenAPIDocumentation();

        webApplication.MapHealthCheckEndpoints();

        webApplication.UseApplicationLogging();

        return webApplication;
    }
}
