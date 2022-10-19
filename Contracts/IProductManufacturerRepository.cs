using Entities.Models;

namespace Contracts
{
    public interface IProductManufacturerRepository
    {
        Task<ProductManufacturer?> GetAsync(Guid id, bool trackChanges);
        Task<IEnumerable<ProductManufacturer>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<ProductManufacturer>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void CreateProductManufacturer(ProductManufacturer productManufacturer);
        void DeleteProductManufacturer(ProductManufacturer productManufacturer);
    }
}
