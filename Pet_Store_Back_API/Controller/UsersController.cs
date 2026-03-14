using Microsoft.AspNetCore.Mvc;

namespace Pet_Store_Back_API.Controller
{
    [Microsoft.AspNetCore.Components.Route("api/controller")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Data.PetStoreContext context;

        public UsersController(Data.PetStoreContext context)
        {
            this.context = context;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var users = context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("GetUserById/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = context.Users.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(Models.Entities.User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = context.Users.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUser(int id, Models.Entities.User updatedUser)
        {
            var user = context.Users.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            user.UserName = updatedUser.UserName;
            user.Name = updatedUser.Name;
            user.LastName = updatedUser.LastName;
            user.PhoneNumber = updatedUser.PhoneNumber;
            user.BirthDate = updatedUser.BirthDate;
            user.Email = updatedUser.Email;
            user.Password = updatedUser.Password;
            await context.SaveChangesAsync();
            return Ok(user);
        }
    }

}