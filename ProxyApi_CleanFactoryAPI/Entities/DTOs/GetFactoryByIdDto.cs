namespace ProxyApi_CleanFactoryAPI.Entities.DTOs
{
    public class GetFactoryByIdDto
    {
        public int Id { get; set; }
        public string FactoryName { get; set; } = string.Empty;
        public DateTime EstablishDate { get; set; } = DateTime.Now;
        public string City { get; set; } = string.Empty;
        public bool isOpened { get; set; } = false;
    }
}
