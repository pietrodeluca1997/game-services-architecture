using GSA.ServiceDefaults.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddApplicationExtensions();

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.UseApplicationExtensions();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();