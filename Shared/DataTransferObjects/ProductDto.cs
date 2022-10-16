namespace Shared.DataTransferObjects
{
    public record ProductDto(Guid Id, string Name, string Description, Decimal Price, Boolean Active, Guid UserUpdate, Guid ProductManufacturerId);
    
}
