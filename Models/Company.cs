using System.ComponentModel.DataAnnotations;

namespace CompanyProductManagement.Models
{
    public class Company
    {   
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string? Name { get; set; }
    }
}