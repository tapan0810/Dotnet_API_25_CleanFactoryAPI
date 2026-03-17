using AutoMapper;
using ProxyApi_CleanFactoryAPI.Entities.DTOs.UserDto;
using ProxyApi_CleanFactoryAPI.Entities.Models;
using ProxyApi_CleanFactoryAPI.Helper.JwtHelper;
using ProxyApi_CleanFactoryAPI.Repositories.UserRepositories;
using BCrypt.Net;

namespace ProxyApi_CleanFactoryAPI.Services
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