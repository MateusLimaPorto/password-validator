using PasswordValidatorAPI.Interfaces;
using System.Text.RegularExpressions;

namespace PasswordValidatorAPI.Rules.Validators
{
    public class HasAtLeastOneUppercaseLetter : IPasswordRules
    {
        public bool Verify(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            var expression = "^(?=.*[A-Z]).*$";

            return Regex.Match(password, expression).Success;
        }
    }
}
