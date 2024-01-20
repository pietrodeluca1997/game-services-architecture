using GSA.ServiceDefaults;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddOpenAPIDocumentation();

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.UseOpenAPIDocumentation();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();