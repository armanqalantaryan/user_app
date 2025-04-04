using System.ComponentModel.DataAnnotations;

namespace user_app.Models.User;

public class UserUpdateDto : IUserModel
{ 
    [MaxLength(50)]
    public string? UserName { get; set; }
    
    [MaxLength(50)]
    [EmailAddress]
    public string? Email { get; set; }
    
    [MaxLength(50)]
    public string? Password { get; set; }
    
}