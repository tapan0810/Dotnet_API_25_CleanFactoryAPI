using ProxyApi_CleanFactoryAPI.Entities.DTOs;
using ProxyApi_CleanFactoryAPI.Entities.Models;

namespace ProxyApi_CleanFactoryAPI.Repositories
{
    public interface IFactoryRepository
    {
        public Task<IEnumerable<Factory>> GetAllFactory(int pageNumber,int pageSize);
        public Task<Factory?> GetFactoryById(int id);

        public Task<Factory> CreateFactory(Factory factory);
        public Task UpdateFactory(Factory updateFactory);
        public Task DeleteFactory(int id);


    }
}
