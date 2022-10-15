namespace Entities.Exceptions
{
    public sealed class CreditCardBrandNotFoundException : NotFoundException
    {
        public CreditCardBrandNotFoundException(Guid id) 
            : base($"The Credit Card Brand  with id: {id} doesn't exist in the database.")
        {
        }
    }
}
