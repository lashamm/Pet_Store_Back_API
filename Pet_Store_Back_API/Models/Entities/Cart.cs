using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Store_Back_API.Models.Entities
{
    public class Cart
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [NotMapped]
        public List<CartItem> Items { get; set; }
        // foreign key to User
        [ForeignKey("user_id")]
        public int UserId { get; set; }
    }
}
