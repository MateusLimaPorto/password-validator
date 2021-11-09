namespace PasswordValidatorAPI.Interfaces
{
    public interface IPasswordRules
    {
        bool Verify(string password);
    }
}
