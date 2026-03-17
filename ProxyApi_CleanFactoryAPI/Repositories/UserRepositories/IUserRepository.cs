using ProxyApi_CleanFactoryAPI.Entities.Models;

namespace ProxyApi_CleanFactoryAPI.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUsername(string username);

        Task<bool> UserExists(string username);

        Task<User> RegisterUser(User user);

    }
}
