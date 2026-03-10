namespace Pet_Store_Back_API.Models.Entities
{
    public class User
    {

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
    
        public string Password { get; set; }
    }
}
