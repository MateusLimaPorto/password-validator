using PasswordValidatorAPI.Interfaces;
using System.Text.RegularExpressions;

namespace PasswordValidatorAPI.Rules.Validators
{
    public class HasAtLeastOneLowercaseLetter : IPasswordRules
    {
        public bool Verify(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            var expression = "^(?=.*[a-z]).*$";

            return Regex.Match(password, expression).Success;
        }
    }
}
