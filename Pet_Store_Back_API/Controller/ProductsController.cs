using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Pet_Store_Back_API.Data;

namespace Pet_Store_Back_API.Controller
{
    [Microsoft.AspNetCore.Components.Route("api/controller")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Data.PetStoreContext context;

        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProducts()
        {
            var products = context.Product.ToList();
            return Ok(products);
        }

        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = context.Product.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct(Models.Entities.Product product)
        {
            context.Product.Add(product);
            await context.SaveChangesAsync();
            return Ok(product);
        }


        [HttpPut("UpdateProduct/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Models.Entities.Product updatedProduct)
        {
            var product = context.Product.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            product.Name = updatedProduct.Name;
            product.Description = updatedProduct.Description;
            product.Price = updatedProduct.Price;
            product.IsAvailable = updatedProduct.IsAvailable;
            product.ImageUrl = updatedProduct.ImageUrl;
            product.Category = updatedProduct.Category;
            await context.SaveChangesAsync();
            return Ok(product);
        }


        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = context.Product.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            context.Product.Remove(product);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
