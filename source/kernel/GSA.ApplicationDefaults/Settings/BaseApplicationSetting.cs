using GSA.ApplicationDefaults.Contracts;
using GSA.ApplicationDefaults.Exceptions;

namespace GSA.ApplicationDefaults.Settings;

public abstract record BaseApplicationSetting : IApplicationSetting
{
    public abstract bool IsValid();

    public void EnsureValidState()
    {
        if (!IsValid())
        {
            throw new InvalidApplicationSettingException($"Configuration {GetType().Name} integrity requirements not met.");
        }
    }
}
