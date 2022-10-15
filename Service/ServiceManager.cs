using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IInfrastructureService> _infrastructureService;
        private readonly Lazy<ICreditCardBrandService> _creditCardBrandService;

        public ServiceManager(
            IRepositoryManager repositoryManager, 
            ILoggerManager logger,
            IMapper mapper)
        {
            _companyService = new Lazy<ICompanyService>(() => 
                new CompanyService(repositoryManager, logger, mapper));
            _infrastructureService = new Lazy<IInfrastructureService>(() => 
                new InfrastructureService(repositoryManager, logger, mapper));
            _creditCardBrandService = new Lazy<ICreditCardBrandService>(() =>
                new CreditCardBrandService(repositoryManager, logger, mapper));
        }

        public ICompanyService CompanyService => _companyService.Value;

        public IInfrastructureService InfrastructureService => _infrastructureService.Value;

        public ICreditCardBrandService CreditCardBrandService => _creditCardBrandService.Value;
    }
}
