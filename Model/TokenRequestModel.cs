using System.ComponentModel.DataAnnotations;

namespace DotNet_JWT_6.Model
{
    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
