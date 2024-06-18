using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourNamespace.Data;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRController : ControllerBase
    {
        private readonly YourDbContext _context;

        public UserRController(YourDbContext context)
        {
            _context = context;
        }

        [HttpGet("role/{role}")]
        public async Task<ActionResult<IEnumerable<string>>> GetUsernamesByRole(string role)
        {
            var usernames = await _context.Users
                .Where(u => u.role == role)
                .Select(u => u.username)
                .ToListAsync();

            return Ok(usernames);
        }
    }
}
