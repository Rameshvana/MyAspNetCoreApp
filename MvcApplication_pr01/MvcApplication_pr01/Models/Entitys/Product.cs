using System.ComponentModel.DataAnnotations;

namespace MvcApplication_pr01.Models.Entitys
{
    public class Product
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0.01, 100000)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Category { get; set; }
    }
}
