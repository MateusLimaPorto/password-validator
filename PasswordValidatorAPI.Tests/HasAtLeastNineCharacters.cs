using PasswordValidatorAPI.Enum;
using PasswordValidatorAPI.Mapper;
using PasswordValidatorAPI.Rules;
using System.Collections.Generic;
using Xunit;

namespace PasswordValidatorAPI.Tests
{
    public class HasAtLeastNineCharacters
    {
        [Fact]
        public void PasswordValidator_VerifyHasAtLeastNineCharacters_3Characters_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "fsd";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasAtLeastNineCharacters_6Characters_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "we45gh";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }


        [Fact]
        public void PasswordValidator_VerifyHasAtLeastNineCharacters_8Characters_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "fwe%2d0v";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasAtLeastNineCharacters_9Characters_ResultTrue()
        {

            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "f34$f%w3&4";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }
    }
}
