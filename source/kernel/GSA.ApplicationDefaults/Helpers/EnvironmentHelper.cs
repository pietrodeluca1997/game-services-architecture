using GSA.ApplicationDefaults.Exceptions;

namespace GSA.ApplicationDefaults.Helpers;

public static class EnvironmentHelper
{
    private const string ENVIRONMENT_NAME_KEY = "ASPNETCORE_ENVIRONMENT";

    public static string RetrieveVariableValue(string environmentKey)
    {
        return Environment.GetEnvironmentVariable(environmentKey) ?? throw new EnvironmentKeyNotFoundException(environmentKey);
    }

    public static string? TryRetrieveVariableValue(string environmentKey)
    {
        return Environment.GetEnvironmentVariable(environmentKey);
    }

    public static string GetEnvironmentName()
    {
        return RetrieveVariableValue(ENVIRONMENT_NAME_KEY);
    }
}
