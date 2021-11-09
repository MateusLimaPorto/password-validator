﻿using PasswordValidatorAPI.Enum;
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
    public class HasAtLeastOneUppercaseLetter
    {
        [Fact]
        public void PasswordValidator_VerifyHasAtLeastOneUppercaseLetter_ResultFalse()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "3as#4343";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_UPPERCASE_LETTER));

            Assert.False(passwordRulesMapper.isValid(rulesValidate));
        }

        [Fact]
        public void PasswordValidator_VerifyHasAtLeastOneUppercaseLetter_ResultTrue()
        {
            GeneralRules rules = new GeneralRules();
            List<object> rulesValidate = new List<object>();
            PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
            string password = "34TFDS@@#";

            rulesValidate.Add(rules.GetRules(password, RuleValidator.AT_LEAST_ONE_UPPERCASE_LETTER));

            Assert.True(passwordRulesMapper.isValid(rulesValidate));
        }
    }
}
