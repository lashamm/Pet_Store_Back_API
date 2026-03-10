namespace Pet_Store_Back_API.Models.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }  
        public int Quantity { get; set; }
        // foreign key to Order
        public int ProductId { get; set; }
    }
}
