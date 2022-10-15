using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class CreditCardBrandService : ICreditCardBrandService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CreditCardBrandService(
            IRepositoryManager repository, 
            ILoggerManager logger, 
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public CreditCardBrandDto? Get(Guid id, bool trackChanges)
        {
            var creditCardBrand = _repository.CreditCardBrand.Get(id, trackChanges);

            if (creditCardBrand is null)
                throw new CreditCardBrandNotFoundException(id);

            var creditCardBrandDto = _mapper.Map<CreditCardBrandDto>(creditCardBrand);

            return creditCardBrandDto;
        }

        public IEnumerable<CreditCardBrandDto> GetAll(bool trackChanges)
        {
            var creditCardBrands = _repository.CreditCardBrand.GetAll(trackChanges);
            var creditCardBrandsDto = _mapper.Map<IEnumerable<CreditCardBrandDto>>(creditCardBrands);

            return creditCardBrandsDto;
        }
    }
}
