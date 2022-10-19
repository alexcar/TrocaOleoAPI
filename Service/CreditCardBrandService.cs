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

        public async Task<CreditCardBrandDto?> GetAsync(Guid id, bool trackChanges)
        {
            var creditCardBrand = await _repository.CreditCardBrand.GetAsync(id, trackChanges);

            if (creditCardBrand is null)
                throw new CreditCardBrandNotFoundException(id);

            var creditCardBrandDto = _mapper.Map<CreditCardBrandDto>(creditCardBrand);

            return creditCardBrandDto;
        }

        public async Task<IEnumerable<CreditCardBrandDto>> GetAllAsync(bool trackChanges)
        {
            var creditCardBrands = await _repository.CreditCardBrand.GetAllAsync(trackChanges);
            var creditCardBrandsDto = _mapper.Map<IEnumerable<CreditCardBrandDto>>(creditCardBrands);

            return creditCardBrandsDto;
        }
    }
}
