using user_app.Data;
using user_app.Models.User;

namespace user_app.Services;

public class UserService : IUserService
{
    private ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<UserDto?> GetUserAsyncByEmail(string email)
    {
        _context.Users.G
    }
}