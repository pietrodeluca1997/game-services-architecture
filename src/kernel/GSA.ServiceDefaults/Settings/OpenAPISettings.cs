using GSA.ServiceDefaults.Contracts;

namespace GSA.ServiceDefaults.Settings;

public sealed record OpenAPISettings : BaseApplicationSetting
{
    public string EndpointName { get; }
    public string Description { get; }
    public string Title { get; }
    public string Version { get; }

    public OpenAPISettings()
    {
        EndpointName = string.Empty;
        Description = string.Empty;
        Title = string.Empty;
        Version = string.Empty;
    }

    public override bool IsValid() => !new[] { EndpointName, Description, Title, Version }.Any(string.IsNullOrWhiteSpace);    
}
