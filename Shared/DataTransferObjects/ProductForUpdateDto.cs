namespace Shared.DataTransferObjects
{
    public record ProductForUpdateDto(
        string Name, 
        string Description, 
        Decimal Price, 
        Boolean Active, 
        Guid UserUpdate);
    
}
