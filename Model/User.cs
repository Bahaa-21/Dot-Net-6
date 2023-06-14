using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DotNet_JWT_6.Model
{
    public class User : IdentityUser
    {
        [Required , StringLength(100)]
        public string FirstName { get; set; } 
        [Required , StringLength(100)]
        public string LastName { get; set; }

        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
