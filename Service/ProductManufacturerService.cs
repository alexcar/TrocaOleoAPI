using AutoMapper;
using Contracts;
using Entities.Exceptions;
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
    }
}
