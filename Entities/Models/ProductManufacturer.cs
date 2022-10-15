namespace Entities.Models
{
    public class ProductManufacturer : Entity
    {
        public string? Name { get; set; }        
        public ICollection<Product>? Products { get; set; }
    }
}
