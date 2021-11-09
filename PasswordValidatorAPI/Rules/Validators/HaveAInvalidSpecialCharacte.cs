using PasswordValidatorAPI.Interfaces;
using System.Text.RegularExpressions;

namespace PasswordValidatorAPI.Rules.Validators
{
    public class HaveAInvalidSpecialCharacte : IPasswordRules
    {
        public bool Verify(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            var expression = "(?=.*[!@#$%^&*()-+]).*$";

            return Regex.Match(password, expression).Success;
        }
    }
}
