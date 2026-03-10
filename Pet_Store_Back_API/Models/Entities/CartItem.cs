namespace Pet_Store_Back_API.Models.Entities
{
    public class CartItem
    {
        public int Id { get; set; }    
        public int Quantity { get; set; }
        // foreign key to Product
        public int ProductId { get; set; }
    }
}
