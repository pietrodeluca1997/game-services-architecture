using HttpMethod = Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod;

namespace GSA.ServiceDefaults.Models;
public record HateoasLinkModel
{
    public string Type { get; init; }
    public string Rel { get; init; }
    public string Href { get; init; }

    public HateoasLinkModel(HttpMethod type, string rel, string href) 
    {
        Type = type.ToString().ToUpper();
        Rel = rel;
        Href = href;
    }
}
