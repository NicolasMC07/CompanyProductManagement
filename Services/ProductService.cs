using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CompanyProductManagement.Models;

namespace CompanyProductManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _http.GetFromJsonAsync<List<Product>>("api/Product") ?? new List<Product>();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"{id}") ?? new Product();
        }

        public async Task<Product> CreateProduct(int companyId, Product product)
        {
            var response = await _http.PostAsJsonAsync($"api/Company/{companyId}/products", product);
            return await response.Content.ReadFromJsonAsync<Product>() ?? new Product();
        }

        public async Task UpdateProduct(int id, Product product)
        {
            await _http.PutAsJsonAsync($"{id}", product);
        }

        public async Task DeleteProduct(int id)
        {
            await _http.DeleteAsync($"{id}");
        }
    }
}