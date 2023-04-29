using Dairy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : Controller
    {
        ApplicationContext context;
        public UsersController(ApplicationContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            if(context.Users.Where(u => u.login == user.login).FirstOrDefault() != null)
            {
                return BadRequest();
            }
            else
            {
                await context.Users.AddAsync(user);
                await context.SaveChangesAsync();
                return Ok(user);
            }
            
        }
    }
}
