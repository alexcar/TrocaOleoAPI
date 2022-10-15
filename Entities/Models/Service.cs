namespace Entities.Models
{
    public class Service : Entity
    {
        public string? Name { get; set; }        
        public ICollection<Company>? Companies { get; set; } = new List<Company>();
        public ICollection<Product>? Producties { get; set; } = new List<Product>();
    }
}
