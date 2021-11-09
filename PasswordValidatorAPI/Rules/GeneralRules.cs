using PasswordValidatorAPI.Enum;
using PasswordValidatorAPI.Interfaces;
using PasswordValidatorAPI.Rules.Validators;
using System.Collections.Generic;
using System.Linq;

namespace PasswordValidatorAPI.Rules
{
    public class GeneralRules : IGeneralRules
    {
        private readonly Dictionary<RuleValidator, object> _rules;

        public GeneralRules()
        {
            _rules = new Dictionary<RuleValidator, object>();
        }

        public void Verify(string password)
        {
            _rules.Add(RuleValidator.HAVE_NON_SPACES, new HaveNonSpaces().Verify(password));
            _rules.Add(RuleValidator.AT_LEAST_ONE_DIGIT, new HasAtLeastOneDigit().Verify(password));
            _rules.Add(RuleValidator.AT_LEAST_NINE_CHARACTERS, new HasAtLeastNineCharacters().Verify(password));
            _rules.Add(RuleValidator.AT_LEAST_ONE_LOWERCASE_LETTER, new HasAtLeastOneLowercaseLetter().Verify(password));
            _rules.Add(RuleValidator.AT_LEAST_ONE_UPPERCASE_LETTER, new HasAtLeastOneUppercaseLetter().Verify(password));
            _rules.Add(RuleValidator.AT_LEAST_ONE_SPECIAL_CHARACTER, new HaveAInvalidSpecialCharacte().Verify(password));
            _rules.Add(RuleValidator.HAVE_NON_REPEATING_CHARACTERS, new HaveNonRepeatingCharacters().Verify(password));
        }

        public object GetRules(string password, RuleValidator rule)
        {
            if (_rules.Values.Count() < 1)
                Verify(password);

            return _rules[rule];
        }
    }
}
