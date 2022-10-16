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

        public IEnumerable<ProductManufacturer> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();
        

        public void CreateProductManufacturer(ProductManufacturer productManufacturer) => Create(productManufacturer);

        public void DeleteProductManufacturer(ProductManufacturer productManufacturer) => Delete(productManufacturer);
        
    }
}
