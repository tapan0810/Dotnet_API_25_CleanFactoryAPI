using ProxyApi_CleanFactoryAPI.Entities.DTOs.UserDto;

namespace ProxyApi_CleanFactoryAPI.Services
{
    public interface IAuthService
    {
        Task<string> Register(RegisterDto dto);
        Task<LoginResponseDto?> Login(LoginDto dto);
    }
}