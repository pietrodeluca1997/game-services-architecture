namespace GSA.ApplicationDefaults.Contracts;

public interface IApplicationSetting
{
    bool IsValid();
    void EnsureValidState();
}
