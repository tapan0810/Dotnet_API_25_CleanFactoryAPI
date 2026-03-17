using ProxyApi_CleanFactoryAPI.Entities.DTOs;

namespace ProxyApi_CleanFactoryAPI.Services
{
    public interface IFactoryService
    {
        public Task<List<GetAllFactoriesDto>> GetAllFactoriesAsync(int pageNumber,int pageSize);
        public Task<GetFactoryByIdDto?> GetFactoryById(int id);
        public Task<GetFactoryByIdDto?> CreateFactory(CreateFactoryDto dto);
        public Task<bool> UpdateFactory(int id, UpdateFactoryDto dto);
        public Task<bool> DeleteFactory(int id);
    }
}
