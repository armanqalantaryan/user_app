using System.ComponentModel.DataAnnotations;

namespace user_app.Models.User;

public class UserDto : IUserModel
{

    public Guid Id { get; set; }

    [Required] [MaxLength(50)] public string UserName { get; set; }

    [Required]
    [MaxLength(50)]
    [EmailAddress]
    public string Email { get; set; }
    
    public string CreatedAt { get; set; }
}