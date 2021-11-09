using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace PasswordValidatorAPI.Mapper
{
    public class PasswordRulesMapper
    {
        public bool isValid(List<object> rule)
        {

            foreach (bool ruleValidate in rule)
            {
                if (!ruleValidate)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
