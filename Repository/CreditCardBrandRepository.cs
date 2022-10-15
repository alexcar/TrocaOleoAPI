using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class CreditCardBrandRepository : RepositoryBase<CreditCardBrand>, ICreditCardBrandRepository
    {
        public CreditCardBrandRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public CreditCardBrand? Get(Guid id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefault();

        public IEnumerable<CreditCardBrand> GetAll(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name).ToList();
        
    }
}
