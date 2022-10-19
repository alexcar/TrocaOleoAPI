using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IProductRepository
    {
        
        Task<Product?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges);
        Task<PagedList<Product>> GetAllAsync(
            Guid productManufacturerId, 
            ProductParameters productParameters, 
            bool trackChanges);
        void CreateProductForProductManufacturer(Guid productManufacturerId, Product product);
        void DeleteProduct(Product product);
    }
}
