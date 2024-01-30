using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GSA.ServiceDefaults.Extensions;

public static partial class ApplicationExtensions
{
    public static IHostApplicationBuilder AddApplicationLogging(this IHostApplicationBuilder appBuilder)
    {
        appBuilder.Logging.ClearProviders();

        appBuilder.Services.AddLogging(builder => builder.AddConsole());

        appBuilder.Services.AddHttpLogging(options =>
        {
            options.LoggingFields = HttpLoggingFields.All;
            options.RequestBodyLogLimit = 4096;
            options.ResponseBodyLogLimit = 4096;
            options.CombineLogs = true;
        });

        return appBuilder;
    }

    public static WebApplication UseApplicationLogging(this WebApplication webApplication)
    {
        webApplication.UseHttpLogging();

        return webApplication;
    }
}
