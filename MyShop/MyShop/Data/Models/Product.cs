using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Data.Models {
    public class Product {
        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Category { get; set; }

        [Required]
        [Range(0, 999.0)]
        public double Price { get; set; }

        public string ImagePath { get; set; } = "";

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
