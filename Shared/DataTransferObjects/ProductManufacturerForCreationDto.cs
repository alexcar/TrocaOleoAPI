namespace Shared.DataTransferObjects
{
    public record ProductManufacturerForCreationDto(
        string Name, Boolean Active, Guid UserUpdate, IEnumerable<ProductForCreationDto> products);
    
}
