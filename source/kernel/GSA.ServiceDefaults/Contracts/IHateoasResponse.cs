using GSA.ServiceDefaults.Models;
using HttpMethod = Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod;

namespace GSA.ServiceDefaults.Contracts;

public interface IHateoasResponse
{
    List<HateoasLinkModel> Links { get; set; }

    void AddLink(HttpMethod type, string rel, Uri href);
}
