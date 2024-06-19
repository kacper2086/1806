using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Data;
using YourNamespace.Models;
using YourNamespace.Services;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly YourDbContext _context;

        private readonly IUserService _userService;

        public UsersController(YourDbContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            // Return only necessary user information, excluding sensitive data
            var userResponse = new
            {
                user.id,
                user.username,
                user.role
            };

            return Ok(userResponse);
        }
        [HttpGet("servis")]
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetServisUsers()
        {
            var servisUsers = await _context.Users
                .Where(u => u.role == "serwis")
                .Select(u => new UserViewModel
                {
                    Id = u.id,
                    Username = u.username
                })
                .ToListAsync();

            return Ok(servisUsers);
        }

        public class UserViewModel
        {
            public int Id { get; set; }
            public string Username { get; set; }
        }
    }
}
