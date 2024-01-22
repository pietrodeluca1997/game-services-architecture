namespace GSA.ServiceDefaults.Contracts;

public interface IApplicationSetting
{
    bool IsValid();
    void EnsureValidState();
}
