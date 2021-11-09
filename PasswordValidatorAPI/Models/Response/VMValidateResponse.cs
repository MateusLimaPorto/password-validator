namespace PasswordValidatorAPI.Models.Response
{
    public class VMValidateResponse
    {
        public bool valid { get; set; }

        public VMValidateResponse(bool isValid)
        {
            valid = isValid;
        }
    }
}
