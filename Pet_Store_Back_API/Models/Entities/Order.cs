using Pet_Store_Back_API.Enums;
namespace Pet_Store_Back_API.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }         
        public DateTime OrderDate { get; set; }   
        public OrderStatus Status { get; set; }  
        public List<OrderItem> Items { get; set; }
        // foreign key to User
        public int UserId { get; set; }
    }
}
