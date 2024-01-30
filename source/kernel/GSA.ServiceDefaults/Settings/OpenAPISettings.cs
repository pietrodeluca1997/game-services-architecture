using GSA.ApplicationDefaults.Settings;

namespace GSA.ServiceDefaults.Settings;

public sealed record OpenAPISettings : BaseApplicationSetting
{
    public string EndpointName { get; init; }
    public string Description { get; init; }
    public string Title { get; init; }
    public string Version { get; init; }

    public OpenAPISettings()
    {
        EndpointName = string.Empty;
        Description = string.Empty;
        Title = string.Empty;
        Version = string.Empty;
    }

    public override bool IsValid() => !new[] { EndpointName, Description, Title, Version }.Any(string.IsNullOrWhiteSpace);
}
