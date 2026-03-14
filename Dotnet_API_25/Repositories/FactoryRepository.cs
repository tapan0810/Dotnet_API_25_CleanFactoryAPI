using Dotnet_API_25.Data;
using Dotnet_API_25.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_25.Repositories
{
    public class FactoryRepository(FactoryDbContext _context) : IFactoryRepository
    {
        public async Task<Factory> CreateFactory(Factory factory)
        {
            _context.Factories.Add(factory);
            await _context.SaveChangesAsync();
            return factory;
        }

        public async Task DeleteFactory(int id)
        {
            var factory = await _context.Factories.FindAsync( id);
            if(factory != null)
            {
                 _context.Factories.Remove(factory);
                await _context.SaveChangesAsync();  
            }
            
        }

        public async Task<IEnumerable<Factory>> GetAllFactory(int pageNumber,int pageSize)
        {
            return await _context.Factories
                .Skip((pageNumber - 1)*pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public Task<Factory?> GetFactoryById(int id)
        {
            return _context.Factories.FirstOrDefaultAsync( x =>x.Id == id);
        }

        public async Task UpdateFactory(Factory updateFactory)
        {
            _context.Factories.Update(updateFactory);
            await _context.SaveChangesAsync();
          
        }
    }
}
