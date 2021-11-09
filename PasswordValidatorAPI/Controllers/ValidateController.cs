using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PasswordValidatorAPI.Enum;
using PasswordValidatorAPI.Interfaces;
using PasswordValidatorAPI.Mapper;
using PasswordValidatorAPI.Models;
using PasswordValidatorAPI.Models.Response;
using System;
using System.Collections.Generic;

namespace PasswordValidatorAPI.Controllers
{
    [ApiController]
    [Route("/v1/password")]
    public class ValidateController : Controller
    {
        private readonly ILogger<ValidateController> _logger;
        private readonly IGeneralRules _rules;
        PasswordRulesMapper passwordRulesMapper = new PasswordRulesMapper();
        List<object> rulesValidate = new List<object>();

        public ValidateController(ILogger<ValidateController> logger, IGeneralRules rules)
        {
            _logger = logger;
            _rules = rules;
        }

        [HttpPost]
        [Route("validate")]
        public IActionResult Validate(VMValidateRequest validate)
        {
            try
            {
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.HAVE_NON_SPACES));
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.AT_LEAST_ONE_DIGIT));
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.AT_LEAST_NINE_CHARACTERS));
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.AT_LEAST_ONE_LOWERCASE_LETTER));
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.AT_LEAST_ONE_UPPERCASE_LETTER));
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.AT_LEAST_ONE_SPECIAL_CHARACTER));
                rulesValidate.Add(_rules.GetRules(validate.password, RuleValidator.HAVE_NON_REPEATING_CHARACTERS));

                return Ok(new VMValidateResponse(passwordRulesMapper.isValid(rulesValidate)));
            }
            catch (Exception error)
            {
                _logger.LogError("Error: " + error.Message);

                return BadRequest(new
                {
                    message = error.Message
                });
            }
        }
    }
}
