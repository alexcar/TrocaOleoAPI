using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal sealed class CreditCardBrandRepository : RepositoryBase<CreditCardBrand>, ICreditCardBrandRepository
    {
        public CreditCardBrandRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<CreditCardBrand?> GetAsync(Guid id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<IEnumerable<CreditCardBrand>> GetAllAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(c => c.Name).ToListAsync();
        
    }
}
