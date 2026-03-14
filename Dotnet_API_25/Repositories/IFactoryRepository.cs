using Dotnet_API_25.Entities.DTOs;
using Dotnet_API_25.Entities.Models;

namespace Dotnet_API_25.Repositories
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
