using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal sealed class ProductManufacturerRepository : RepositoryBase<ProductManufacturer>, IProductManufacturerRepository
    {
        public ProductManufacturerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<ProductManufacturer?> GetAsync(Guid id, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public async Task<IEnumerable<ProductManufacturer>> GetAllAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(p => p.Name).ToListAsync();

        public async Task<IEnumerable<ProductManufacturer>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();        

        public void CreateProductManufacturer(ProductManufacturer productManufacturer) => Create(productManufacturer);

        public void DeleteProductManufacturer(ProductManufacturer productManufacturer) => Delete(productManufacturer);
        
    }
}
