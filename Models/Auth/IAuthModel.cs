using System.ComponentModel.DataAnnotations;

namespace user_app.Models;

public interface IAuthModel
{
    public string UserName { get; set; }
    public string Password { get; set; }

}