using PasswordValidatorAPI.Enum;
using PasswordValidatorAPI.Mapper;
using PasswordValidatorAPI.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PasswordValidatorAPI.Tests
{
    public class HaveNonRepeatingCharacters
    {
        [Fact]
        public void PasswordValidator_VerifyHaveNonRepeatingCharacters_RepeatingCharactereSpecial_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "@#@eryfg";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.HAVE_NON_REPEATING_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHaveNonRepeatingCharacters_RepeatingCharactereInterger_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "23345543";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.HAVE_NON_REPEATING_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHaveNonRepeatingCharacters_RepeatingCharacter_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "AAAbbbCc+";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.HAVE_NON_REPEATING_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHaveNonRepeatingCharacters_ResultTrue()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "AbTp9!fok";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.HAVE_NON_REPEATING_CHARACTERS));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }
    }
}
