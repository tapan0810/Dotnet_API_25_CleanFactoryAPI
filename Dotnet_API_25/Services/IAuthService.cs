using Dotnet_API_25.Entities.DTOs.UserDto;

namespace Dotnet_API_25.Services
{
    public interface IAuthService
    {
        Task<string> Register(RegisterDto dto);
        Task<LoginResponseDto?> Login(LoginDto dto);
    }
}