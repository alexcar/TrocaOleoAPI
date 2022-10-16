using Contracts;
using Entities.Models;

namespace Repository
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public Product? GetById(Guid productManufacturerId, Guid id, bool trackChanges) =>
            FindByCondition(p => p.ProductManufacturerId.Equals(productManufacturerId) && 
                p.Id.Equals(id), trackChanges).SingleOrDefault();


        public IEnumerable<Product> GetAll(Guid productManufacturerId, bool trackChanges) =>
            FindByCondition(pm => pm.ProductManufacturerId.Equals(productManufacturerId), trackChanges)
                .OrderBy(p => p.Name).ToList();

        public void CreateProductForProductManufacturer(Guid productManufacturerId, Product product)
        {
            product.ProductManufacturerId = productManufacturerId;
            Create(product);
        }

        public void DeleteProduct(Product product) => Delete(product);
        
    }
}
