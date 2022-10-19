using Entities.Models;

namespace Contracts
{
    public interface ICreditCardBrandRepository
    {
        Task<IEnumerable<CreditCardBrand>> GetAllAsync(bool trackChanges);
        Task<CreditCardBrand?> GetAsync(Guid id, bool trackChanges);
    }
}
