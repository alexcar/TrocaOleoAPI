using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IProductManufacturerService
    {
        ProductManufacturerDto? GetById(Guid id, bool trackChanges);
        IEnumerable<ProductManufacturerDto> GetAll(bool trackChanges);
        IEnumerable<ProductManufacturerDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        (IEnumerable<ProductManufacturerDto> productManufactures, string ids) CreateProductManufacturerCollection(
            IEnumerable<ProductManufacturerForCreationDto> productManufacturerCollection);
        ProductManufacturerDto CreateProductManufacturer(ProductManufacturerForCreationDto productManufacturer);
    }
}
