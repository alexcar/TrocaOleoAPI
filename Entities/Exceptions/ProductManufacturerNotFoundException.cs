namespace Entities.Exceptions
{
    public sealed class ProductManufacturerNotFoundException : NotFoundException
    {
        public ProductManufacturerNotFoundException(Guid id) 
            : base($"The product manufacturer with id: {id} doesn't exist in the database.")
        {
        }
    }
}
