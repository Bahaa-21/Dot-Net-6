using Microsoft.AspNetCore.Identity;

namespace DotNet_JWT_6.Model
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }

        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
