using user_app.Data;
using user_app.Models;

namespace user_app.Services.Auth;

public class AuthService : IAuthService
{

    private readonly ApplicationDbContext _context;
    
    public AuthService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<AuthResult> LoginAsync(LoginModel model)
    {
        throw new NotImplementedException();
    }

    public Task<AuthResult> RegisterAsync(RegisterModel model)
    {
        throw new NotImplementedException();
    }

   public void Logout()
    {
        throw new NotImplementedException();
    }
}