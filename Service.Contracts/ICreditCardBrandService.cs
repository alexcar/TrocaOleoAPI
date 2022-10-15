using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICreditCardBrandService
    {
        IEnumerable<CreditCardBrandDto> GetAll(bool trackChanges);
        CreditCardBrandDto? Get(Guid id, bool trackChanges);
    }
}
