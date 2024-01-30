using GSA.ServiceDefaults.Contracts;
using HttpMethod = Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod;

namespace GSA.ServiceDefaults.Models;

public abstract record HateoasResponse : IHateoasResponse
{
    public List<HateoasLinkModel> Links { get; set; }

    protected HateoasResponse()
    {
        Links = [];
    }

    public void AddLink(HttpMethod type, string rel, string href)
    {
        Links.Add(new HateoasLinkModel(type, rel, href));
    }
}
