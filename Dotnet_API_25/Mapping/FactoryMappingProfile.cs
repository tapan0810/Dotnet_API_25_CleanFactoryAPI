using AutoMapper;
using Dotnet_API_25.Entities.DTOs;
using Dotnet_API_25.Entities.Models;

namespace Dotnet_API_25.Mapping
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
