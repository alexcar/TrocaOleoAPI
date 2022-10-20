using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System.ComponentModel;

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

        public async Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetAllAsync(
            Guid productManufacturerId,
            ProductParameters productParameters,
            bool trackChanges)
        {
            if (!productParameters.ValidPriceRange())
                throw new MaxPriceRangeBadRequestException();
            
            await GetProductManufacturerAndCheckIfExists(productManufacturerId, trackChanges);            
            var productsWithMetaData = await _repository.Product.GetAllAsync(productManufacturerId, productParameters, trackChanges);
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(productsWithMetaData);

            return (products: productsDto, metaData: productsWithMetaData.MetaData);
        }

        public async Task<ProductDto?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges)
        {
            await GetProductManufacturerAndCheckIfExists(productManufacturerId, trackChanges);
            var product = await _repository.Product.GetByIdAsync(productManufacturerId, id, trackChanges);

            if (product is null)
                throw new ProductNotFoundException(id);

            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }

        public async Task<ProductDto> CreateProductForProductManufacturerAsync(
            Guid productManufacturerId, ProductForCreationDto productForCreation, bool trackChanges)
        {
            await GetProductManufacturerAndCheckIfExists(productManufacturerId, trackChanges);
            var productEntity = _mapper.Map<Product>(productForCreation);

            productEntity.CreationDate = DateTime.Now;
            
            _repository.Product.CreateProductForProductManufacturer(productManufacturerId, productEntity);            
            await _repository.SaveAsync();

            var productToReturn = _mapper.Map<ProductDto>(productEntity);

            return productToReturn;
        }

        public async Task UpdateProductForProductManufacturerAsync(
            Guid productManufacturerId, 
            Guid id, ProductForUpdateDto productForUpdate, 
            bool manufTrackChanges, bool prodTrackChanges)
        {
            await GetProductManufacturerAndCheckIfExists(productManufacturerId, manufTrackChanges);
            var productEntity = await GetProductForManufacturterAndCheckIfExists(productManufacturerId, id, prodTrackChanges);

            _mapper.Map(productForUpdate, productEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteProductForProductManufacturerAsync(Guid productManufacturerId, Guid id, bool trackChanges)
        {
            await GetProductManufacturerAndCheckIfExists(productManufacturerId, trackChanges);
            var productForProductManufacturer = await GetProductForManufacturterAndCheckIfExists(productManufacturerId, id, trackChanges);

            _repository.Product.DeleteProduct(productForProductManufacturer);
            await _repository.SaveAsync();
        }

        private async Task<ProductManufacturer> GetProductManufacturerAndCheckIfExists(Guid id, bool trackChanges)
        {
            var pm = await _repository.ProductManufacturer.GetAsync(id, trackChanges);

            if (pm is null)
                throw new ProductManufacturerNotFoundException(id);

            return pm;
        }

        private async Task<Product> GetProductForManufacturterAndCheckIfExists(Guid productManufacturerId, Guid productId, bool trackChanges)
        {
            var productForProductManufacturer = await _repository.Product.GetByIdAsync(productManufacturerId, productId, trackChanges);

            if (productForProductManufacturer is null)
                throw new ProductNotFoundException(productId);

            return productForProductManufacturer;
        }
    }
}
