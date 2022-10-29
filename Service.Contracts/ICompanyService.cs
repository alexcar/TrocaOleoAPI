using Entities.Responses;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetAllCompaniesAsync(bool trackChanges);
        Task<CompanyDto?> GetCompanyAsync(Guid id, bool trackChanges);
        Task<IEnumerable<CompanyDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<(IEnumerable<CompanyDto> companies, string ids)> CreateCompanyCollectionAsync(
            IEnumerable<CompanyForCreationDto> companyCollection);
        Task<CompanyDto> CreateCompanyAsync(CompanyForCreationDto company);
        ApiBaseResponse GetAllCompanies(bool trackChanges);
        ApiBaseResponse GetCompany(Guid id, bool trackChanges);
    }
}
