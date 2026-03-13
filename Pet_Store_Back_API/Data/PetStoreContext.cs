using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pet_Store_Back_API.Data
{
    public class PetStoreContext : IdentityDbContext
    {
        public PetStoreContext(DbContextOptions options) : base(options)
        {
        }

        protected PetStoreContext()
        {
        }

        public DbSet<Models.Entities.Pet> Pets { get; set; }
        public DbSet<Models.Entities.ProductCategory> ProductCategories { get; set; }
        public DbSet<Models.Entities.Cart> Carts { get; set; }
        public DbSet<Models.Entities.CartItem> CartItems { get; set; }
        public DbSet<Models.Entities.User> Users { get; set; }
        public DbSet<Models.Entities.Product> Product { get; set; } 
        public DbSet<Models.Entities.Order> Order { get; set; }
        public DbSet<Models.Entities.OrderItem> OrderItem { get; set; }

    }
}
