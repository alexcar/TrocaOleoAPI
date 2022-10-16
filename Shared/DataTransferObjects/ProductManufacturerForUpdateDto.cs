namespace Shared.DataTransferObjects
{
    public record ProductManufacturerForUpdateDto(
        string Name, Boolean Active, Guid UserUpdate, IEnumerable<ProductForCreationDto> Products);    
}
