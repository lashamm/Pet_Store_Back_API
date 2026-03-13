using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Store_Back_API.Models.Entities
{
    public class OrderItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("product_name")]
        public string ProductName { get; set; }  
        [Column("quantity")]
        public int Quantity { get; set; }
        // foreign key to Order
        [ForeignKey("order_id")]
        public int ProductId { get; set; }
    }
}
