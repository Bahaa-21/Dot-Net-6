using System.ComponentModel.DataAnnotations;

namespace DotNet_JWT_6.Model;

public class AddRoleModel
{
    [Required]
    public string UserId { get; set; }
    [Required]
    public string Role { get; set; }

}
