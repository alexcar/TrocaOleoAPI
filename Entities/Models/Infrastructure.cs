namespace Entities.Models
{
    public class Infrastructure : Entity
    {
        public string? Name { get; set; }
        public ICollection<Company>? Companies { get; set; } = new List<Company>();
    }
}
