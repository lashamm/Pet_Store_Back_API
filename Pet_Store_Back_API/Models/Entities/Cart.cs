using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet_Store_Back_API.Models.Entities
{
    public class Cart
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [NotMapped]
        // foreign key to User
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
