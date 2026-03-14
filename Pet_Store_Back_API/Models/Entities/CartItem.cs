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
        [ForeignKey("product_id")]
        public int ProductId { get; set; }
        [ForeignKey("cart_id")]
        public int CartId { get; set; }
    }
}
