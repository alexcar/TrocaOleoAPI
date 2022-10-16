using Entities.Models;

namespace Contracts
{
    public interface IProductRepository
    {
        Product? GetById(Guid productManufacturerId, Guid id, bool trackChanges);
        IEnumerable<Product> GetAll(Guid productManufacturerId, bool trackChanges);
        void CreateProductForProductManufacturer(Guid productManufacturerId, Product product);
    }
}
