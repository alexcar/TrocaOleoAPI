using Entities.Models;

namespace Contracts
{
    public interface IProductManufacturer
    {
        ProductManufacturer? Get(Guid id, bool trackChanges);
        IEnumerable<ProductManufacturer> GetAll(bool trackChanges);
    }
}
