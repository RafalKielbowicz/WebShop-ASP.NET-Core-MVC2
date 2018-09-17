using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter product name.")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please enter product description.")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage="Please enter positive value.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter category.")]
        public string Category { get; set; }
    }
}