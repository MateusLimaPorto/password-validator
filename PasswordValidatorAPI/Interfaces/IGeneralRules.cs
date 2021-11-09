using PasswordValidatorAPI.Enum;

namespace PasswordValidatorAPI.Interfaces
{
    public interface IGeneralRules
    {
        void Verify(string password);
        object GetRules(string password, RuleValidator rule);
    }
}
