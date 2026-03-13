using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pet_Store_Back_API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pet_Store_Back_API.Models.Entities
{
    public class ProductCategory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        // foreign key to PetCategory enum
        [ForeignKey("pet_category_id")]
        public int PetCategoryId { get; set; }
        [NotMapped]
        public PetCategory PetCategory { get; set; }
    }
}
