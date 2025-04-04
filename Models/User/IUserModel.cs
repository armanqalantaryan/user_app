using System.ComponentModel.DataAnnotations;

namespace user_app.Models.User;

public interface IUserModel
{
    string UserName { get; set; }
    
    string Email { get; set; }
}