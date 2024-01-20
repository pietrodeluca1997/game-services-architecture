namespace GSA.ServiceDefaults.Exceptions;

public class MissingConfigurationException(string missingConfigurationKey) : Exception(BuildExceptionMessage(missingConfigurationKey))
{
    private static string BuildExceptionMessage(string missingConfigurationKey) => $"Configuration key {missingConfigurationKey} not found.";
}
