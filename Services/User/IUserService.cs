using user_app.Data;
using user_app.Models.User;

namespace user_app.Services;

public interface IUserService
{
    Task<UserDto?> GetUserAsyncByEmail(string email);
    
    Task<UserDto?> GetUserAsyncByUserName(string userName);
    
    Task<UserDto> CreateUserAsync(UserCreateDto model);
    
    Task<UserDto> UpdateUserAsync(UserUpdateDto model);
    
}