using Pet_Store_Back_API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pet_Store_Back_API.Models.Entities
{
    public class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("order_date")]
        public DateTime OrderDate { get; set; }
        [Column("status")]
        public OrderStatus Status { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        // foreign key to User
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
