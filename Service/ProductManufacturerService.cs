using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Runtime.CompilerServices;

namespace Service
{
    internal sealed class ProductManufacturerService : IProductManufacturerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductManufacturerService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductManufacturerDto?> GetByIdAsync(Guid id, bool trackChanges)
        {
            var productManufacturer = await _repository.ProductManufacturer.GetAsync(id, trackChanges);

            if (productManufacturer is null)
                throw new ProductManufacturerNotFoundException(id);

            var pmDto = _mapper.Map<ProductManufacturerDto>(productManufacturer);

            return pmDto;
        }

        public async Task<IEnumerable<ProductManufacturerDto>> GetAllAsync(bool trackChanges)
        {
            var pms = await _repository.ProductManufacturer.GetAllAsync(trackChanges);
            var pmsDto = _mapper.Map<IEnumerable<ProductManufacturerDto>>(pms);

            return pmsDto;
        }

        public async Task<IEnumerable<ProductManufacturerDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var pms = await _repository.ProductManufacturer.GetByIdsAsync(ids, trackChanges);

            if (ids.Count() != pms.Count())
                throw new CollectionByIdsBadRequestException();

            var pmsToReturn = _mapper.Map<IEnumerable<ProductManufacturerDto>>(pms);

            return pmsToReturn;
        }

        public async Task<(IEnumerable<ProductManufacturerDto> productManufactures, string ids)>
            CreateProductManufacturerCollectionAsync(IEnumerable<ProductManufacturerForCreationDto> productManufacturerCollection)
        {
            if (productManufacturerCollection is null)
                throw new CompanyCollectionBadRequest();

            var productManufacturerEntities = _mapper.Map<IEnumerable<ProductManufacturer>>(productManufacturerCollection);

            foreach (var productManufacturer in productManufacturerEntities)
            {
                _repository.ProductManufacturer.CreateProductManufacturer(productManufacturer);
            }

            await _repository.SaveAsync();

            var productManufacturerToReturn =
                _mapper.Map<IEnumerable<ProductManufacturerDto>>(productManufacturerEntities);
            var ids = string.Join(",", productManufacturerToReturn.Select(c => c.Id));

            return (productManufactures: productManufacturerToReturn, ids: ids);
        }

        public async Task<ProductManufacturerDto> CreateProductManufacturerAsync(ProductManufacturerForCreationDto productManufacturer)
        {
            var pmEntity = _mapper.Map<ProductManufacturer>(productManufacturer);

            pmEntity.CreationDate = DateTime.Now;

            _repository.ProductManufacturer.CreateProductManufacturer(pmEntity);
            await _repository.SaveAsync();

            var pmToReturn = _mapper.Map<ProductManufacturerDto>(pmEntity);

            return pmToReturn;
        }

        public async Task UpdateProductManufacturerAsync(
            Guid productManufacturerId, ProductManufacturerForUpdateDto productManufacturerForUpdate, bool trackChanges)
        {
            var pmEntity = await GetProductManufacturerAndCheckIfExists(productManufacturerId, trackChanges);

            _mapper.Map(productManufacturerForUpdate, pmEntity);
            await _repository.SaveAsync();
        }

        public async Task DeleteProductManufacturerAsync(Guid id, bool trackChanges)
        {
            var pm = await GetProductManufacturerAndCheckIfExists(id, trackChanges);

            _repository.ProductManufacturer.DeleteProductManufacturer(pm);
            await _repository.SaveAsync();
        }

        private async Task<ProductManufacturer> GetProductManufacturerAndCheckIfExists(Guid id, bool trackChanges)
        {
            var pm = await _repository.ProductManufacturer.GetAsync(id, trackChanges);

            if (pm is null)
                throw new ProductManufacturerNotFoundException(id);

            return pm;
        }
    }
}
