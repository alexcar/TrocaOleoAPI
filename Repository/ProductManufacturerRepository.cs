using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class ProductManufacturerRepository : RepositoryBase<ProductManufacturer>, IProductManufacturerRepository
    {
        public ProductManufacturerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public ProductManufacturer? Get(Guid id, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(id), trackChanges).SingleOrDefault();


        public IEnumerable<ProductManufacturer> GetAll(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(p => p.Name).ToList();
        
    }
}
