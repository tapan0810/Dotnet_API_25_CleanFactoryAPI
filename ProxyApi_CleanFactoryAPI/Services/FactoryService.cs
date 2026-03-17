using AutoMapper;
using ProxyApi_CleanFactoryAPI.Entities.DTOs;
using ProxyApi_CleanFactoryAPI.Entities.Models;
using ProxyApi_CleanFactoryAPI.Repositories;

namespace ProxyApi_CleanFactoryAPI.Services
{
    public class FactoryService(IMapper _mapper, IFactoryRepository _repository) : IFactoryService
    {
        public async Task<GetFactoryByIdDto?> CreateFactory(CreateFactoryDto dto)
        {
            var factory = _mapper.Map<Factory>(dto);

            var create = await _repository.CreateFactory(factory);

            return _mapper.Map<GetFactoryByIdDto>(create);
        }

        public async Task<bool> DeleteFactory(int id)
        {
            await _repository.DeleteFactory(id);

            return true;
        }

        public async Task<List<GetAllFactoriesDto>> GetAllFactoriesAsync(int pageNumber, int pageSize)
        {
            var factory = await _repository.GetAllFactory(pageNumber, pageSize);

            return _mapper.Map<List<GetAllFactoriesDto>>(factory);
        }

        public async Task<GetFactoryByIdDto?> GetFactoryById(int id)
        {
            var factory = await _repository.GetFactoryById(id);

            if(factory is not null)
            {
                return _mapper.Map<GetFactoryByIdDto>(factory);
            }

            return null;
            
        }

        public async Task<bool> UpdateFactory(int id, UpdateFactoryDto dto)
        {

           var result = await _repository.GetFactoryById(id);

            if (result is null) return false;

            _mapper.Map(dto, result);

            await _repository.UpdateFactory(result);

            return true;

        }
    }
}
