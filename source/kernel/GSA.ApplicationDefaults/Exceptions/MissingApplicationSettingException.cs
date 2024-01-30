namespace GSA.ApplicationDefaults.Exceptions;

public class MissingApplicationSettingException : Exception
{
    public MissingApplicationSettingException()
    {

    }

    public MissingApplicationSettingException(string message)
        : base(message)
    {

    }

    public MissingApplicationSettingException(string message, Exception inner)
        : base(message, inner)
    {

    }
}