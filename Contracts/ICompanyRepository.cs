﻿using Entities.Models;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company? GetCompany(Guid id, bool trackChanges);
        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        void CreateCompany(Company company);
    }
}
