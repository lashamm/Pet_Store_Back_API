using Pet_Store_Back_API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Store_Back_API.Models.Entities
{
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Required]
        [Column("price")]
        public decimal Price { get; set; }
        [Column("is_available")]
        public bool IsAvailable { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
        [Column("category")]
        public CategoryName Category { get; set; }
    }
}
