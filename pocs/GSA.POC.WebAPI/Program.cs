using GSA.ServiceDefaults.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddWebApplicationExtensions();

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.UseWebApplicationExtensions();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();