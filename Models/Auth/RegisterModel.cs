using System.ComponentModel.DataAnnotations;

namespace user_app.Models;

public class RegisterModel : IAuthModel
{
    
    [Required]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }
}