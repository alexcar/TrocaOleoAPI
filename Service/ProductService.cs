using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProductDto> GetAll(Guid productManufacturerId, bool trackChanges)
        {
            var productManfacturer = _repository.ProductManufacturer.Get(productManufacturerId, trackChanges);

            if (productManfacturer is null)
                throw new ProductManufacturerNotFoundException(productManufacturerId);
            
            var products = _repository.Product.GetAll(productManufacturerId, trackChanges);
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }

        public ProductDto? GetById(Guid productManufacturerId, Guid id, bool trackChanges)
        {
            var productManfacturer = _repository.ProductManufacturer.Get(productManufacturerId, trackChanges);

            if (productManfacturer is null)
                throw new ProductManufacturerNotFoundException(productManufacturerId);

            var product = _repository.Product.GetById(productManufacturerId, id, trackChanges);

            if (product is null)
                throw new ProductNotFoundException(id);

            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }

        public ProductDto CreateProductForProductManufacturer(
            Guid productManufacturerId, ProductForCreationDto productForCreation, bool trackChanges)
        {
            var productManufacturer = _repository.ProductManufacturer.Get(productManufacturerId, trackChanges);

            if (productManufacturer is null)
                throw new ProductManufacturerNotFoundException(productManufacturerId);

            var productEntity = _mapper.Map<Product>(productForCreation);

            productEntity.CreationDate = DateTime.Now;
            
            _repository.Product.CreateProductForProductManufacturer(productManufacturerId, productEntity);            
            _repository.Save();

            var productToReturn = _mapper.Map<ProductDto>(productEntity);

            return productToReturn;
        }

        public void DeleteProductForProductManufacturer(Guid productManufacturerId, Guid id, bool trackChanges)
        {
            var productManufacturer = _repository.ProductManufacturer.Get(productManufacturerId, trackChanges);

            if (productManufacturer is null)
                throw new ProductManufacturerNotFoundException(productManufacturerId);

            var productForProductManufacturer = _repository.Product.GetById(productManufacturerId, id, trackChanges);

            if (productForProductManufacturer is null)
                throw new ProductNotFoundException(id);

            _repository.Product.DeleteProduct(productForProductManufacturer);
            _repository.Save();
        }
    }
}
