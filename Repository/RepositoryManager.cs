using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IInfrastructureRepository> _infrastructureRepository;
        private readonly Lazy<ICreditCardBrandRepository> _creditCardBrandRepository;
        private readonly Lazy<IProductManufacturerRepository> _productManufacturerRepository;
        private readonly Lazy<IProductRepository> _productRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            
            _companyRepository = new Lazy<ICompanyRepository>(
                () => new CompanyRepository(repositoryContext));
            
            _infrastructureRepository = new Lazy<IInfrastructureRepository>(
                () => new InfrastructureRepository(repositoryContext));

            _creditCardBrandRepository = new Lazy<ICreditCardBrandRepository>(
                () => new CreditCardBrandRepository(repositoryContext));

            _productManufacturerRepository = new Lazy<IProductManufacturerRepository>(
                () => new ProductManufacturerRepository(repositoryContext));

            _productRepository = new Lazy<IProductRepository>(
                () => new ProductRepository(repositoryContext));
        }

        public ICompanyRepository Company => _companyRepository.Value;
        public IInfrastructureRepository Infrastructure => _infrastructureRepository.Value;
        public ICreditCardBrandRepository CreditCardBrand => _creditCardBrandRepository.Value;
        public IProductManufacturerRepository ProductManufacturer => _productManufacturerRepository.Value;

        public IProductRepository Product => _productRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
