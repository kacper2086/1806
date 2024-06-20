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
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] Users model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Check if the username already exists
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.username == model.username);
                if (existingUser != null)
                {
                    return Conflict(new { message = "User with this username already exists" });
                }

                // Create a new user object
                var newUser = new Users
                {
                    username = model.username,
                    password = model.password, // Note: You should hash/salt the password in a real application
                    role = model.role
                };

                // Add user to context and save changes
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();

                // Return the newly created user
                return CreatedAtRoute("GetUserById", new { id = newUser.id }, newUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }
        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);

                if (user == null)
                {
                    return NotFound(new { message = "User not found" });
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            try
            {
                var users = await _context.Users.ToListAsync();

                // Map users to a simplified view model or directly return them, depending on security considerations
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }






        // Request models for input data
        public class CreateUserRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        public class UserViewModel
        {
            public int Id { get; set; }
            public string Username { get; set; }
        }
    }
}
