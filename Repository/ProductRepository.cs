using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Shared.RequestFeatures;

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


        public async Task<PagedList<Product>> GetAllAsync(
            Guid productManufacturerId, 
            ProductParameters productParameters,
            bool trackChanges)
        {
            //var products = await 
            //    FindByCondition(product =>
            //        product.ProductManufacturerId.Equals(productManufacturerId) &&
            //        (
            //            product.Price >= productParameters.MinPrice && 
            //            product.Price <= productParameters.MaxPrice
            //        ), trackChanges)
            //    .OrderBy(p => p.Name)
            //    .Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
            //    .Take(productParameters.PageSize)
            //    .ToListAsync();

            //var count = await 
            //    FindByCondition(e => e.ProductManufacturerId.Equals(productManufacturerId), trackChanges)
            //        .CountAsync();

            //return new PagedList<Product>(products, count, productParameters.PageNumber, productParameters.PageSize);

            var products = await FindByCondition(
                p => p.ProductManufacturerId.Equals(productManufacturerId), trackChanges)
                .FilterProducts(productParameters.MinPrice, productParameters.MaxPrice)
                .Search(productParameters.SearchTerm)
                .Sort(productParameters.OrderBy)
                .ToListAsync();

            return PagedList<Product>
                .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }
            

        public void CreateProductForProductManufacturer(Guid productManufacturerId, Product product)
        {
            product.ProductManufacturerId = productManufacturerId;
            Create(product);
        }

        public void DeleteProduct(Product product) => Delete(product);
        
    }
}
