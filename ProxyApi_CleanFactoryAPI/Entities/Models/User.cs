namespace ProxyApi_CleanFactoryAPI.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string HashPassword { get; set; } = string.Empty;
    }
}
