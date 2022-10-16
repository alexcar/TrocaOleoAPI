namespace Shared.DataTransferObjects
{
    public record ProductForCreationDto(
        string Name, string Description, Decimal Price, 
        Boolean Active, Guid UserUpdate);    
}
