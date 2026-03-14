using Microsoft.AspNetCore.Mvc;

namespace Pet_Store_Back_API.Controller
{
    [Microsoft.AspNetCore.Components.Route("api/controller")]
    [ApiController]
    public class CartController :ControllerBase
    {
            private readonly Data.PetStoreContext context;
    
            public CartController(Data.PetStoreContext context)
            {
                this.context = context;
            }

        [HttpPost("AddToCart")]
        public async Task<IActionResult> AddToCart(Models.Entities.CartItem cartItem)
        {
            context.CartItems.Add(cartItem);
            await context.SaveChangesAsync();
            return Ok(cartItem);
        }

        [HttpGet("GetCartItemsByCartId/{cartId}")]
        public async Task<IActionResult> GetCartItemsByCartId(int cartId)
        {
            var cartItems = context.CartItems.Where(ci => ci.CartId == cartId).ToList();
            return Ok(cartItems);
        }
        [HttpDelete("RemoveFromCart/{id}")]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var cartItem = context.CartItems.FirstOrDefault(ci => ci.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }
            context.CartItems.Remove(cartItem);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
