using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICreditCardBrandService
    {
        Task<IEnumerable<CreditCardBrandDto>> GetAllAsync(bool trackChanges);
        Task<CreditCardBrandDto?> GetAsync(Guid id, bool trackChanges);
    }
}
