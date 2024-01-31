using GSA.ServiceCommunicationChannel.Extensions;
using GSA.ServiceDefaults.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddGameProfileCommunication("http://localhost:5002");

builder.AddWebApplicationExtensions();

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.UseWebApplicationExtensions();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseDefaultRouting();

app.Run();