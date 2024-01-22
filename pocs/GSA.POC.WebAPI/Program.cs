using GSA.ServiceDefaults.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddOpenAPIDocumentation();

builder.AddApplicationHealthCheck();

builder.AddApplicationLogging();

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.UseOpenAPIDocumentation();

app.MapHealthCheckEndpoints();

app.UseApplicationLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();