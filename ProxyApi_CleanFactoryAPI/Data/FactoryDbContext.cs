using ProxyApi_CleanFactoryAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ProxyApi_CleanFactoryAPI.Data
{
    public class FactoryDbContext:DbContext
    {
        public FactoryDbContext(DbContextOptions<FactoryDbContext> options) : base(options) { }

        public DbSet<Factory>Factories =>Set<Factory>();

        public DbSet<User> Users => Set<User>();
    }
}
