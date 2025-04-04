namespace user_app.Data;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string UserName { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string PasswordHash { get; set; }
    
    [Required]
    [MaxLength(50)]
    [EmailAddress]
    public string Email { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? DeletedAt { get; set; } 
    
}