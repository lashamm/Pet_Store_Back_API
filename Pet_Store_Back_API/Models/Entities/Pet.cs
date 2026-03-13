using Pet_Store_Back_API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pet_Store_Back_API.Models.Entities
{
    public class Pet
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("pet")]
        public PetCategory Category { get; set; }
    }
}
