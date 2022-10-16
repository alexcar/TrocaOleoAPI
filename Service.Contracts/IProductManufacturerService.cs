using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IProductManufacturerService
    {
        ProductManufacturerDto? GetById(Guid id, bool trackChanges);
        IEnumerable<ProductManufacturerDto> GetAll(bool trackChanges);
    }
}
