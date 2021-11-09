using Microsoft.Extensions.Logging;
using PasswordValidatorAPI.Enum;
using PasswordValidatorAPI.Interfaces;
using PasswordValidatorAPI.Mapper;
using PasswordValidatorAPI.Rules;
using System.Collections.Generic;
using Xunit;

namespace PasswordValidatorAPI.Tests
{
    public class HaveNonSpacesOrEmptyOrNullTest
    {
        [Fact]
        public void PasswordValidator_VerifyHasHaveNonSpaces_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = " ";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasHaveNonEmpty_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasHaveNonNull_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = null;

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasHaveNonSpacesOrEmptyOrNull_ResultTrue()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "AbTp9!fok";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_NINE_CHARACTERS));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }
    }
}
