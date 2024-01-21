using GSA.ServiceDefaults.Exceptions;

namespace GSA.ServiceDefaults.Contracts;

public interface IApplicationSetting
{
    bool IsValid();
    void EnsureValidState();
}
