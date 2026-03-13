using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Store_Back_API.Models.Entities
{
    public class CartItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        // foreign key to Product
        [ForeignKey("Product_id")]
        public int ProductId { get; set; }
    }
}
