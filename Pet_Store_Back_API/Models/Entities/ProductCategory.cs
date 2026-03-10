using Pet_Store_Back_API.Enums;
namespace Pet_Store_Back_API.Models.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PetCategoryId { get; set; }
        public PetCategory PetCategory { get; set; }
    }
}
