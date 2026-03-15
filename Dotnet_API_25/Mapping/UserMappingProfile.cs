using AutoMapper;
using Dotnet_API_25.Entities.DTOs.UserDto;
using Dotnet_API_25.Entities.Models;

namespace Dotnet_API_25.Mapping
{
    public class UserMappingProfile:Profile
    {
        public UserMappingProfile() 
        {
            CreateMap<RegisterDto, User>();

            CreateMap<User, LoginDto>();
        }
    }
}
