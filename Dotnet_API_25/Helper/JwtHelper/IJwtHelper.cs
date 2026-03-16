using Dotnet_API_25.Entities.Models;

namespace Dotnet_API_25.Helper.JwtHelper
{
    public interface IJwtHelper
    {
        public string GenerateToken(User user);
    }
}
