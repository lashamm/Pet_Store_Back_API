namespace Pet_Store_Back_API.Models.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public List<CartItem> Items { get; set; }
        // foreign key to User
        public int UserId { get; set; }
    }
}
