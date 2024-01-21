using GSA.ServiceDefaults.Contracts;
using GSA.ServiceDefaults.Exceptions;

namespace GSA.ServiceDefaults.Settings;

public abstract record BaseApplicationSetting : IApplicationSetting
{
    public abstract bool IsValid();

    public void EnsureValidState()
    {        
        if (!IsValid())
        {
            throw new InvalidApplicationSettingException($"Configuration {this.GetType().Name} integrity requirements not met.");
        }        
    }
}
