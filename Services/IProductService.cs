using CompanyProductManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyProductManagement.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProduct(int id);
        Task<Product> CreateProduct(int companyId, Product product);
        Task UpdateProduct(int id, Product product);
        Task DeleteProduct(int id);
    }
}