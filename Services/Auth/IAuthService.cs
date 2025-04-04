using Microsoft.AspNetCore.Identity.Data;
using user_app.Models;

namespace user_app.Services;

public interface IAuthService
{
    Task<AuthResult> RegisterAsync(RegisterModel model);
    Task<AuthResult> LoginAsync(LoginModel model);

    void Logout();
}