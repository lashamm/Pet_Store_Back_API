using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Store_Back_API.Models.Entities
{
    public class User
    {
        [Key]
        [Column("id")]  
        public int Id { get; set; }
        [Required]
        [Column("username")]
        public string UserName { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("birth_date")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("password")]
        public string Password { get; set; }
    }
}
