using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IProductManufacturerService
    {
        Task<ProductManufacturerDto?> GetByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<ProductManufacturerDto>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<ProductManufacturerDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<(IEnumerable<ProductManufacturerDto> productManufactures, string ids)> CreateProductManufacturerCollectionAsync(
            IEnumerable<ProductManufacturerForCreationDto> productManufacturerCollection);
        Task<ProductManufacturerDto> CreateProductManufacturerAsync(ProductManufacturerForCreationDto productManufacturer);
        Task UpdateProductManufacturerAsync(
            Guid productManufacturerId, ProductManufacturerForUpdateDto productManufacturerForUpdate, bool trackChanges);
        Task DeleteProductManufacturerAsync(Guid id, bool trackChanges);
    }
}
