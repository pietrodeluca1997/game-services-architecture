using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GSA.ServiceDefaults.Extensions;

public static partial class ApplicationExtensions
{
    public static IHostApplicationBuilder AddApplicationExtensions(this IHostApplicationBuilder builder)
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

    public static WebApplication UseApplicationExtensions(this WebApplication webApplication)
    {
        webApplication.UseOpenAPIDocumentation();

        webApplication.MapHealthCheckEndpoints();

        webApplication.UseApplicationLogging();

        return webApplication;
    }
}
