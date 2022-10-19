using Entities.Models;

namespace Contracts
{
    public interface IProductRepository
    {
        
        Task<Product?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges);
        Task<IEnumerable<Product>> GetAllAsync(Guid productManufacturerId, bool trackChanges);
        void CreateProductForProductManufacturer(Guid productManufacturerId, Product product);
        void DeleteProduct(Product product);
    }
}
