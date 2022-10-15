using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IInfrastructureRepository> _infrastructureRepository;
        private readonly Lazy<ICreditCardBrandRepository> _creditCardBrandRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            
            _companyRepository = new Lazy<ICompanyRepository>(
                () => new CompanyRepository(repositoryContext));
            
            _infrastructureRepository = new Lazy<IInfrastructureRepository>(
                () => new InfrastructureRepository(repositoryContext));

            _creditCardBrandRepository = new Lazy<ICreditCardBrandRepository>(
                () => new CreditCardBrandRepository(repositoryContext));
        }

        public ICompanyRepository Company => _companyRepository.Value;
        public IInfrastructureRepository Infrastructure => _infrastructureRepository.Value;

        public ICreditCardBrandRepository CreditCardBrand => _creditCardBrandRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}
