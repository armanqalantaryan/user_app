using System.ComponentModel.DataAnnotations;

namespace user_app.Models;

public class LoginModel : IAuthModel
{
    [Required]
    [MaxLength(50)]
    public string UserName { get; set; }
    
    [Required]
    [MaxLength(255)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
}