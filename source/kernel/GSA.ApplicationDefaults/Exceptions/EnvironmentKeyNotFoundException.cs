namespace GSA.ApplicationDefaults.Exceptions;

public class EnvironmentKeyNotFoundException : Exception
{
    public EnvironmentKeyNotFoundException()
    {

    }

    public EnvironmentKeyNotFoundException(string message)
        : base(message)
    {

    }

    public EnvironmentKeyNotFoundException(string message, Exception inner)
        : base(message, inner)
    {

    }
}