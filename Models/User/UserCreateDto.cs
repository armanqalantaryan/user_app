using System.ComponentModel.DataAnnotations;

namespace user_app.Models.User;

public class UserCreateDto : IUserModel
{
    
    [Required] [MaxLength(50)] public string UserName { get; set; }

    [Required]
    [MaxLength(50)]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Password { get; set; }

}