using PasswordValidatorAPI.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace PasswordValidatorAPI.Rules.Validators
{
    public class HaveNonRepeatingCharacters : IPasswordRules
    {
        public bool Verify(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            return isValid(password);
        }

        public static bool isValid(string password)
        {

            int index = 0;
            int qtd = password.Length;
            int qtdSecond = password.Length;
            string passwordModify = password;
            string aux = null;
            int count = 0;

            for (int i = 0; i < qtd; i++)
            {
                aux = password.Substring(index, 1);

                for (int j = 0; j < qtdSecond; j++)
                {
                    if (aux.Equals(passwordModify.Substring(0, 1)))
                    {
                        count++;

                        if (count > 1)
                            return false;

                    }
                    passwordModify = passwordModify.Remove(0, 1);
                }

                index++;
                count = 0;
                passwordModify = password;
            }

            return true;
        }
    }
}
