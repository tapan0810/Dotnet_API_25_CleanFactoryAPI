using AutoMapper;
using ProxyApi_CleanFactoryAPI.Entities.DTOs.UserDto;
using ProxyApi_CleanFactoryAPI.Entities.Models;

namespace ProxyApi_CleanFactoryAPI.Mapping
{
    public class UserMappingProfile:Profile
    {
        public UserMappingProfile() 
        {
            CreateMap<RegisterDto, User>()
                .ForMember(x => x.HashPassword, opt => opt.MapFrom(y => y.Password));

     
        }
    }
}
