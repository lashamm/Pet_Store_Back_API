using Pet_Store_Back_API.Enums;
namespace Pet_Store_Back_API.Models.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PetCategory Category { get; set; }
    }
}
