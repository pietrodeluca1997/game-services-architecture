using GSA.ServiceCommunicationChannel.Providers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GSA.ServiceCommunicationChannel.Extensions;

public static class ServicesConfiguration
{
    public static IHostApplicationBuilder AddGameProfileCommunication(this IHostApplicationBuilder appBuilder, string serviceBaseAddress)
    {
        appBuilder.Services.AddScoped(provider =>
        {
            IHttpClientFactory httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();

            return new GameProfileServiceCommunicationProvider(httpClientFactory.CreateClient(nameof(GameProfileServiceCommunicationProvider)));
        });

        appBuilder.Services.AddHttpClient(nameof(GameProfileServiceCommunicationProvider), httpClient =>
        {
            httpClient.BaseAddress = new Uri(serviceBaseAddress);
        });

        return appBuilder;
    }
}
