using GSA.ServiceDefaults.Exceptions;
using GSA.ServiceDefaults.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GSA.ServiceDefaults;

public static partial class ApplicationExtensions
{
    public static IApplicationBuilder UseOpenAPIDocumentation(this WebApplication app)
    {        
        IConfiguration appConfiguration = app.Configuration;
        OpenAPISettings openAPISettings = appConfiguration.GetSection(nameof(OpenAPISettings)).Get<OpenAPISettings>() ?? throw new MissingConfigurationException(nameof(OpenAPISettings));

        app.UseSwagger();
        app.UseSwaggerUI(swaggerSetup =>
        {           
            swaggerSetup.SwaggerEndpoint($"/swagger/{openAPISettings.Version}/swagger.json", openAPISettings.EndpointName);
        });

        // Root of the app redirects to the swagger endpoint and not show in docs
        app.MapGet("/", () => Results.Redirect("/swagger", permanent: true)).ExcludeFromDescription();

        return app;
    }

    public static IHostApplicationBuilder AddOpenAPIDocumentation(this IHostApplicationBuilder appBuilder)
    {      
        IServiceCollection services = appBuilder.Services;
        IConfiguration appConfiguration = appBuilder.Configuration;
        OpenAPISettings openAPISettings = appConfiguration.GetSection(nameof(OpenAPISettings)).Get<OpenAPISettings>() ?? throw new MissingConfigurationException(nameof(OpenAPISettings));

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(swaggerOptions =>
        {
            swaggerOptions.SwaggerDoc(openAPISettings.Version, new OpenApiInfo
            {
                Title = openAPISettings.Title,
                Version = openAPISettings.Version,
                Description = openAPISettings.Description
            });
        });

        return appBuilder;
    }
}
