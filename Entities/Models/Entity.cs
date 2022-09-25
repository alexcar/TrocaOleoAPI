namespace Entities.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public Guid UserUpdate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
