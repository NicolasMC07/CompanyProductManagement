using System.Net.Http.Json;
using CompanyProductManagement.Models;

namespace CompanyProductManagement.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly HttpClient _http;

        public CompanyService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _http.GetFromJsonAsync<List<Company>>("api/Company") ?? new List<Company>();
        }

        public async Task<Company> GetCompany(int id)
        {
            return await _http.GetFromJsonAsync<Company>($"api/Company/{id}") ?? new Company();
        }

        public async Task<Company> CreateCompany(Company company)
        {
            var response = await _http.PostAsJsonAsync("api/Company", company);
            return await response.Content.ReadFromJsonAsync<Company>() ?? new Company();
        }

        public async Task UpdateCompany(int id, Company company)
        {
            await _http.PutAsJsonAsync($"api/Company/{id}", company);
        }

        public async Task DeleteCompany(int id)
        {
            await _http.DeleteAsync($"api/Company/{id}");
        }

        public async Task<List<Product>> GetCompanyProducts(int companyId)
        {
            return await _http.GetFromJsonAsync<List<Product>>($"api/Company/{companyId}/products") ?? new List<Product>();
        }
    }
}