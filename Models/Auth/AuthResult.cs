using user_app.Models.User;

namespace user_app.Models;

public class  AuthResult
{
     public bool success { get; set; }
     
     public string message { get; set; }
     
     public UserDto? user { get; set; }
     
     public AuthResult(bool success, string message, UserDto? user = null)
     {
          this.success = success;
          this.message = message;
          this.user = user;
     }
}