using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Product?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.ProductManufacturerId.Equals(productManufacturerId) && 
                p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public async Task<IEnumerable<Product>> GetAllAsync(Guid productManufacturerId, bool trackChanges) =>
            await FindByCondition(pm => pm.ProductManufacturerId.Equals(productManufacturerId), trackChanges)
                .OrderBy(p => p.Name).ToListAsync();

        public void CreateProductForProductManufacturer(Guid productManufacturerId, Product product)
        {
            product.ProductManufacturerId = productManufacturerId;
            Create(product);
        }

        public void DeleteProduct(Product product) => Delete(product);
        
    }
}
