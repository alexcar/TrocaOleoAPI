using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IProductService
    {
        Task<ProductDto?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges);
        Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetAllAsync(
            Guid productManufacturerId, ProductParameters productParameters, bool trackChanges);
        Task<ProductDto> CreateProductForProductManufacturerAsync(
            Guid productManufacturerId, ProductForCreationDto productForCreation, bool trackChanges);
        Task UpdateProductForProductManufacturerAsync(
            Guid productManufacturerId, Guid id, 
            ProductForUpdateDto productForUpdate, 
            bool manufTrackChanges, bool prodTrackChanges);
        Task DeleteProductForProductManufacturerAsync(Guid productManufacturerId, Guid id, bool trackChanges);
    }
}
