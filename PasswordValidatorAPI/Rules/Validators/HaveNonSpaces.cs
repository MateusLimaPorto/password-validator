using PasswordValidatorAPI.Interfaces;

namespace PasswordValidatorAPI.Rules.Validators
{
    public class HaveNonSpaces : IPasswordRules
    {
        public bool Verify(string password)
        {
            if (!string.IsNullOrWhiteSpace(password))
                return true;
            else
                return false;
        }
    }
}
