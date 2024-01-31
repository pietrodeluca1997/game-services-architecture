using GSA.ApplicationDefaults.Contracts;
using GSA.ApplicationDefaults.Exceptions;
using Microsoft.Extensions.Configuration;

namespace GSA.ApplicationDefaults.Extensions;

public static partial class ConfigurationExtensions
{
    public static TApplicationSetting TryConfigureApplicationSetting<TApplicationSetting>(this IConfiguration configuration, string keyName) where TApplicationSetting : IApplicationSetting
    {
        TApplicationSetting applicationSetting = configuration.GetSection(keyName).Get<TApplicationSetting>() ?? throw new MissingApplicationSettingException(typeof(TApplicationSetting).Name);

        applicationSetting.EnsureValidState();

        return applicationSetting;
    }
}
