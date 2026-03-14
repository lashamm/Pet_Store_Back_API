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
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; }

        public Product Product { get; set; }
        public Cart Cart { get; set; }
    }
}
