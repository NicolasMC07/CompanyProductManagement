using System.ComponentModel.DataAnnotations;

namespace CompanyProductManagement.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public int CompanyId { get; set; }
        
        public Company? Company { get; set; }
    }
}