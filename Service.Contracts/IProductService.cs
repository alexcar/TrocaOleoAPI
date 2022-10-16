using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IProductService
    {
        ProductDto? GetById(Guid productManufacturerId, Guid id, bool trackChanges);
        IEnumerable<ProductDto> GetAll(Guid productManufacturerId, bool trackChanges);
        ProductDto CreateProductForProductManufacturer(
            Guid productManufacturerId, ProductForCreationDto productForCreation, bool trackChanges);
    }
}
