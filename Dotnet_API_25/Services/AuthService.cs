using AutoMapper;
using Dotnet_API_25.Entities.DTOs.UserDto;
using Dotnet_API_25.Entities.Models;
using Dotnet_API_25.Helper.JwtHelper;
using Dotnet_API_25.Repositories.UserRepositories;
using BCrypt.Net;

namespace Dotnet_API_25.Services
{
    public class AuthService(IMapper mapper, IUserRepository userRepository, IJwtHelper jwtHelper) : IAuthService
    {
        public async Task<string> Register(RegisterDto dto)
        {
            if (await userRepository.UserExists(dto.UserName))
            {
                throw new Exception("User already exists");
            }

            var user = mapper.Map<User>(dto);
            user.HashPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password); 

            await userRepository.RegisterUser(user);
            return "User registered successfully";
        }

        public async Task<LoginResponseDto?> Login(LoginDto dto)
        {
            var user = await userRepository.GetUserByUsername(dto.UserName);
            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.HashPassword)) 
            {
                return null;
            }

            var token = jwtHelper.GenerateToken(user!); 
            return new LoginResponseDto { Token = token, UserName = user.UserName };
        }
    }
}