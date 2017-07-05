using Microsoft.AspNet.Identity;

namespace ElecSales.WebTools
{
    /// <summary>
    /// √‹¬Î≤ªº”√‹
    /// </summary>
    public class NonPasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            return password;
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            if (hashedPassword == providedPassword)
            {
                return PasswordVerificationResult.Success;
            }
            return PasswordVerificationResult.Failed;
        }
    }
}