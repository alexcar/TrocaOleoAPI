namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IInfrastructureRepository Infrastructure { get; }
        ICreditCardBrandRepository CreditCardBrand { get; }
        IProductManufacturerRepository ProductManufacturer { get; }
        IProductRepository Product { get; }
        void Save();
    }
}
