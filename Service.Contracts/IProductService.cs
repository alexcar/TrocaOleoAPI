using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IProductService
    {
        Task<ProductDto?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges);
        Task<IEnumerable<ProductDto>> GetAllAsync(Guid productManufacturerId, bool trackChanges);
        Task<ProductDto> CreateProductForProductManufacturerAsync(Guid productManufacturerId, ProductForCreationDto productForCreation, bool trackChanges);
        Task UpdateProductForProductManufacturerAsync(
            Guid productManufacturerId, Guid id, 
            ProductForUpdateDto productForUpdate, 
            bool manufTrackChanges, bool prodTrackChanges);
        Task DeleteProductForProductManufacturerAsync(Guid productManufacturerId, Guid id, bool trackChanges);
    }
}
