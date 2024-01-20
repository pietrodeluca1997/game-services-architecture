namespace GSA.ServiceDefaults.Settings;

public sealed record OpenAPISettings
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
}
