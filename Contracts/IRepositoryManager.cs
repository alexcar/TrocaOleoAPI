namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IInfrastructureRepository Infrastructure { get; }
        ICreditCardBrandRepository CreditCardBrand { get; }
        void Save();
    }
}
