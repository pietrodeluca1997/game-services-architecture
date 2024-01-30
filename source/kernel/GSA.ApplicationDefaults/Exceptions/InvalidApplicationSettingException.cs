namespace GSA.ApplicationDefaults.Exceptions;

public class InvalidApplicationSettingException : Exception
{
    public InvalidApplicationSettingException()
    {

    }

    public InvalidApplicationSettingException(string message)
        : base(message)
    {

    }

    public InvalidApplicationSettingException(string message, Exception inner)
        : base(message, inner)
    {

    }
}