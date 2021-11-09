using PasswordValidatorAPI.Enum;
using PasswordValidatorAPI.Mapper;
using PasswordValidatorAPI.Rules;
using System.Collections.Generic;
using Xunit;

namespace PasswordValidatorAPI.Tests
{
    public class HasAtLeastOneDigit
    {
        [Fact]
        public void PasswordValidator_VerifyHasAtLeastOneDigitInteger_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "f";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_DIGIT));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasAtLeastOneDigitInteger_3Digit_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "fsd";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_DIGIT));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasAtLeastOneDigit_ResultTrue()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "1";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_DIGIT));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasAtLeastOneDigit_3Digit_ResultTrue()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "134";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_DIGIT));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }
    }
}
