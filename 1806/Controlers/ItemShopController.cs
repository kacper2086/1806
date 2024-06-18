using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourNamespace.Data;

[Route("api/[controller]")]
[ApiController]
public class ItemShopController : ControllerBase
{
    private readonly YourDbContext _context;

    public ItemShopController(YourDbContext context)
    {
        _context = context;
    }

    // GET: api/itemshop
    [HttpGet]
    public async Task<ActionResult<IEnumerable<object>>> GetItemShops()
    {
        return await _context.ItemShop
            .Select(item => new { item.Name, item.Price })
            .ToListAsync();
    }

    // GET: api/itemshop/5
    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetItemShop(int id)
    {
        var itemShop = await _context.ItemShop
            .Where(i => i.Id == id)
            .Select(item => new { item.Name, item.Price })
            .FirstOrDefaultAsync();

        if (itemShop == null)
        {
            return NotFound();
        }

        return itemShop;
    }
}
