using Entities.Models;

namespace Contracts
{
    public interface IProductManufacturerRepository
    {
        ProductManufacturer? Get(Guid id, bool trackChanges);
        IEnumerable<ProductManufacturer> GetAll(bool trackChanges);
    }
}
