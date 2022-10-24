using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IInfrastructureService> _infrastructureService;
        private readonly Lazy<ICreditCardBrandService> _creditCardBrandService;
        private readonly Lazy<IProductManufacturerService> _productManufacturerService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IAuthenticationService> _authenticationService; 

        public ServiceManager(
            IRepositoryManager repositoryManager, 
            ILoggerManager logger,
            IMapper mapper,
            UserManager<User> userManager,
            IConfiguration configuration)
        {
            _companyService = new Lazy<ICompanyService>(() => 
                new CompanyService(repositoryManager, logger, mapper));
            
            _infrastructureService = new Lazy<IInfrastructureService>(() => 
                new InfrastructureService(repositoryManager, logger, mapper));
            
            _creditCardBrandService = new Lazy<ICreditCardBrandService>(() =>
                new CreditCardBrandService(repositoryManager, logger, mapper));

            _productManufacturerService = new Lazy<IProductManufacturerService>(() =>
                new ProductManufacturerService(repositoryManager, logger, mapper));

            _productService = new Lazy<IProductService>(() =>
                new ProductService(repositoryManager, logger, mapper));

            _authenticationService = new Lazy<IAuthenticationService>(() => 
                new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public ICompanyService CompanyService => _companyService.Value;

        public IInfrastructureService InfrastructureService => _infrastructureService.Value;

        public ICreditCardBrandService CreditCardBrandService => _creditCardBrandService.Value;

        public IProductManufacturerService ProductManufacturerService => _productManufacturerService.Value;

        public IProductService ProductService => _productService.Value;

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
