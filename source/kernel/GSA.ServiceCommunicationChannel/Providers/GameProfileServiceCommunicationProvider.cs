using GSA.ApplicationDefaults.Extensions;
using GSA.Core.Queries.Shared;
using GSA.ServiceCommunicationChannel.Contracts;

namespace GSA.ServiceCommunicationChannel.Providers;

public class GameProfileServiceCommunicationProvider(HttpClient httpClient) : IServiceCommunicationProvider
{
    public async Task<CharacterListQueryResponse?> GetCharactersList()
    {
        return await (await httpClient.Get("/api/characters")).ReadContentAsJson<CharacterListQueryResponse>();
    }
}
