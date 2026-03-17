namespace ProxyApi_CleanFactoryAPI.Entities.DTOs.UserDto
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}