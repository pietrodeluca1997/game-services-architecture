using GSA.ServiceDefaults.Contracts;
using GSA.ServiceDefaults.Exceptions;
using Microsoft.Extensions.Configuration;

namespace GSA.ServiceDefaults.Extensions;

public static partial class ConfigurationExtensions
{
    public static TApplicationSetting TryConfigureApplicationSetting<TApplicationSetting>(this IConfiguration configuration, string keyName) where TApplicationSetting : IApplicationSetting
    {
        TApplicationSetting applicationSetting = configuration.GetSection(keyName).Get<TApplicationSetting>() ?? throw new MissingApplicationSettingException(nameof(TApplicationSetting));

        applicationSetting.EnsureValidState();

        return applicationSetting;
    }
}
