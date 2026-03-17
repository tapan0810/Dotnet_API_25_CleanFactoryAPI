using ProxyApi_CleanFactoryAPI.Data;
using ProxyApi_CleanFactoryAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ProxyApi_CleanFactoryAPI.Repositories.UserRepositories
{
    public class UserRepository(FactoryDbContext _context) : IUserRepository
    {
        public async Task<User?> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<User> RegisterUser(User user)
        {

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
            
        }

        public async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username);
        }
    }
}
