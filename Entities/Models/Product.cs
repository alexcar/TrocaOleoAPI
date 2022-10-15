namespace Entities.Models
{
    public class Product : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Decimal Price { get; set; }
        public ICollection<Service>? Services { get; set; } = new List<Service>();
        public Guid ProductManufacturerId { get; set; }
        public ProductManufacturer? ProductManufacturer { get; set; }
    }
}
