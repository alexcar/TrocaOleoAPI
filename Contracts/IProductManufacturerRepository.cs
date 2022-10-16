using Entities.Models;

namespace Contracts
{
    public interface IProductManufacturerRepository
    {
        ProductManufacturer? Get(Guid id, bool trackChanges);
        IEnumerable<ProductManufacturer> GetAll(bool trackChanges);
        IEnumerable<ProductManufacturer> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void CreateProductManufacturer(ProductManufacturer productManufacturer);
        void DeleteProductManufacturer(ProductManufacturer productManufacturer);
    }
}
