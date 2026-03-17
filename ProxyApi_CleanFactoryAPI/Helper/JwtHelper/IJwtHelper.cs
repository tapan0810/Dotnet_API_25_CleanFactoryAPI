using ProxyApi_CleanFactoryAPI.Entities.Models;

namespace ProxyApi_CleanFactoryAPI.Helper.JwtHelper
{
    public interface IJwtHelper
    {
        public string GenerateToken(User user);
    }
}
