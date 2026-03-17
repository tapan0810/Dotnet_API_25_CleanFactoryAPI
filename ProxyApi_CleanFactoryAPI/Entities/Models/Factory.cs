namespace ProxyApi_CleanFactoryAPI.Entities.Models
{
    public class Factory
    {
        public int Id { get; set; }
        public string FactoryName { get; set; } = string.Empty;
        public DateTime EstablishDate { get; set; } = DateTime.Now;
        public string City { get; set; } = string.Empty;
        public bool isOpened { get; set; } = false;

    }
}
