using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

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

        public ProductManufacturerDto? GetById(Guid id, bool trackChanges)
        {
            var productManufacturer = _repository.ProductManufacturer.Get(id, trackChanges);

            if (productManufacturer is null)
                throw new ProductManufacturerNotFoundException(id);

            var pmDto = _mapper.Map<ProductManufacturerDto>(productManufacturer);

            return pmDto;
        }

        public IEnumerable<ProductManufacturerDto> GetAll(bool trackChanges)
        {
            var pms = _repository.ProductManufacturer.GetAll(trackChanges);
            var pmsDto = _mapper.Map<IEnumerable<ProductManufacturerDto>>(pms);

            return pmsDto;
        }

        public IEnumerable<ProductManufacturerDto> GetByIds(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var pms = _repository.ProductManufacturer.GetByIds(ids, trackChanges);

            if (ids.Count() != pms.Count())
                throw new CollectionByIdsBadRequestException();

            var pmsToReturn = _mapper.Map<IEnumerable<ProductManufacturerDto>>(pms);

            return pmsToReturn;
        }

        public (IEnumerable<ProductManufacturerDto> productManufactures, string ids) 
            CreateProductManufacturerCollection(IEnumerable<ProductManufacturerForCreationDto> productManufacturerCollection)
        {
            if (productManufacturerCollection is null)
                throw new CompanyCollectionBadRequest();

            var productManufacturerEntities = _mapper.Map<IEnumerable<ProductManufacturer>>(productManufacturerCollection);

            foreach (var productManufacturer in productManufacturerEntities)
            {
                _repository.ProductManufacturer.CreateProductManufacturer(productManufacturer);
            }

            _repository.Save();

            var productManufacturerToReturn =
                _mapper.Map<IEnumerable<ProductManufacturerDto>>(productManufacturerEntities);
            var ids = string.Join(",", productManufacturerToReturn.Select(c => c.Id));

            return (productManufactures: productManufacturerToReturn, ids: ids);
        }

        public ProductManufacturerDto CreateProductManufacturer(ProductManufacturerForCreationDto productManufacturer)
        {
            var pmEntity = _mapper.Map<ProductManufacturer>(productManufacturer);

            pmEntity.CreationDate = DateTime.Now;

            _repository.ProductManufacturer.CreateProductManufacturer(pmEntity);
            _repository.Save();

            var pmToReturn = _mapper.Map<ProductManufacturerDto>(pmEntity);

            return pmToReturn;
        }

        public void DeleteProductManufacturer(Guid id, bool trackChanges)
        {
            var pm = _repository.ProductManufacturer.Get(id, trackChanges);

            if (pm is null)
                throw new ProductManufacturerNotFoundException(id);

            _repository.ProductManufacturer.DeleteProductManufacturer(pm);
            _repository.Save();
        }
    }
}
