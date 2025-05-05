// Services/ICompanyService.cs
using CompanyProductManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyProductManagement.Services
{
    public interface ICompanyService
    {   
        Task<List<Product>> GetCompanyProducts(int companyId);
        Task<List<Company>> GetCompanies();
        Task<Company> GetCompany(int id);
        Task<Company> CreateCompany(Company company);
        Task UpdateCompany(int id, Company company);
        Task DeleteCompany(int id);
    }
}