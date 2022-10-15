using Entities.Models;

namespace Contracts
{
    public interface ICreditCardBrandRepository
    {
        IEnumerable<CreditCardBrand> GetAll(bool trackChanges);
        CreditCardBrand? Get(Guid id, bool trackChanges);
    }
}
