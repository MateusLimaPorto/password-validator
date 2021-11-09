using PasswordValidatorAPI.Interfaces;
using System.Text.RegularExpressions;

namespace PasswordValidatorAPI.Rules.Validators
{
    public class HasAtLeastOneDigit : IPasswordRules
    {
        public bool Verify(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            var expression = "^(?=.*[0-9]).*$";

            return Regex.Match(password, expression).Success;
        }
    }
}
