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
    public class HaveAInvalidSpecialCharacte
    {
        [Fact]
        public void PasswordValidator_VerifyHaveAInvalidSpecialCharacte_NoCharactereSpecial_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "4554fdgfg";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_SPECIAL_CHARACTER));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHaveAInvalidSpecialCharacte_CharacterSpecialInvalid_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "fds¨dvv";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_SPECIAL_CHARACTER));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHaveAInvalidSpecialCharacte_ResultTrue()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "34*(TFDS@#";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_SPECIAL_CHARACTER));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }
    }
}
