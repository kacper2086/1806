using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourNamespace.Models;  // Załóżmy, że namespace Twojego modelu to YourNamespace.Models
using YourNamespace.Data;    // Załóżmy, że namespace Twojego DbContextu to YourNamespace.Data

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly YourDbContext _context;

        public EventController(YourDbContext context)
        {
            _context = context;
        }

        // GET: api/Event
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvent()
        {
            return await _context.Event.ToListAsync();
        }

        // GET: api/Event/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var @event = await _context.Event.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            return @event;
        }

        // POST: api/Event
        [HttpPost]
        public async Task<ActionResult<Event>> AddEvent(Event @event)
        {
            _context.Event.Add(@event);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEvent), new { id = @event.Id }, @event);
        }

        // PUT: api/Event/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, Event @event)
        {
            if (id != @event.Id)
            {
                return BadRequest();
            }

            var existingEvent = await _context.Event.FindAsync(id);
            if (existingEvent == null)
            {
                return NotFound();
            }

            existingEvent.Title = @event.Title;
            existingEvent.StartDate = @event.StartDate;
            existingEvent.EndDate = @event.EndDate;
            existingEvent.Serwisant = @event.Serwisant;
            existingEvent.PartName = @event.PartName;  // Uwzględniamy nullowalność PartName

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Event/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Event/title/{title}
        [HttpGet("title/{title}")]
        public async Task<IActionResult> GetEventByTitle(string title)
        {
            var @event = await _context.Event.FirstOrDefaultAsync(e => e.Title == title);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
