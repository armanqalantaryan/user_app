using Microsoft.EntityFrameworkCore;
using user_app.Data;
using user_app.Models;
using BCrypt.Net;


namespace user_app.Services.Auth;

public class AuthService : IAuthService
{

    private readonly ApplicationDbContext _context;
    
    public AuthService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AuthResult> LoginAsync(LoginModel model)
    {
        throw new NotImplementedException();
    }

    public async Task<AuthResult> RegisterAsync(RegisterModel model)
    {
        try
        {
            var existingUser  = await _context.Users.AnyAsync(u => u.Email == model.Email);
            if (existingUser)
            {
                return new AuthResult(false, "Email already exists");
            }
            existingUser = await _context.Users.AnyAsync(u => u.UserName == model.UserName);
            if (existingUser)
            {
                return new AuthResult(false, "Username already exists");us
            }

            var newUser = new User
            {
                Email = model.Email,
                UserName = model.UserName,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password),
                CreatedAt = DateTime.Now,
            };

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
        }
        
    }

   public void Logout()
    {
        throw new NotImplementedException();
    }
}