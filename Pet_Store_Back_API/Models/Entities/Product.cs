using Pet_Store_Back_API.Enums;

namespace Pet_Store_Back_API.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public CategoryName Category { get; set; }
    }
}
