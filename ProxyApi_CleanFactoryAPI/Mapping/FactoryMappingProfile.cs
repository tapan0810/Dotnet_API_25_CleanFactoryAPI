using AutoMapper;
using ProxyApi_CleanFactoryAPI.Entities.DTOs;
using ProxyApi_CleanFactoryAPI.Entities.Models;

namespace ProxyApi_CleanFactoryAPI.Mapping
{
    public class FactoryMappingProfile:Profile
    {
        public FactoryMappingProfile() 
        {
            CreateMap<Factory, GetAllFactoriesDto>();

            CreateMap<Factory, GetFactoryByIdDto>();

            CreateMap<UpdateFactoryDto,Factory>();

            CreateMap<CreateFactoryDto,Factory>();

        }
    }
}
