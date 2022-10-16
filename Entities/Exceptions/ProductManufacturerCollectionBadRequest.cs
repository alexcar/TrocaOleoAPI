namespace Entities.Exceptions
{
    public sealed class ProductManufacturerCollectionBadRequest : BadRequestException
    {
        public ProductManufacturerCollectionBadRequest()
            : base("Product Manufacturer collection sent from a client is null.")
        {
        }
    }
}
