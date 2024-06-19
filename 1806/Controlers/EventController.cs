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
        // GET: api/Event/ended
        [HttpGet("ended")]
        public async Task<ActionResult<IEnumerable<EventViewModel>>> GetEndedEventTitles()
        {
            var endedEvents = await _context.Event
                .Where(e => e.Status == "ended")
                .Select(e => new EventViewModel
                {
                    Title = e.Title,
                    StartDate = e.StartDate
                })
                .ToListAsync();

            return Ok(endedEvents);
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
            existingEvent.Part = @event.Part;
            existingEvent.Status = @event.Status;

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
        // GET: api/Event/ended
        [HttpGet("started")]
        public async Task<ActionResult<IEnumerable<EventViewModel>>> GetStartedEventTitles()
        {
            var startedEvents = await _context.Event
                .Where(e => e.Status == "started" || e.Status == "in progress")
                .Select(e => new EventViewModel
                {
                    Title = e.Title,
                    StartDate = e.StartDate
                })
                .ToListAsync();

            return Ok(startedEvents);
        }


        // PUT: api/Event/title/{title}/startDate/{startDate}
        [HttpPut("title/{title}/startDate/{startDate}")]
        public async Task<IActionResult> UpdateEventByTitleAndStartDate(string title, DateTime startDate, Event @event)
        {
            var existingEvent = await _context.Event.FirstOrDefaultAsync(e => e.Title == title && e.StartDate == startDate);

            if (existingEvent == null)
            {
                return NotFound();
            }

            if (existingEvent.Part != "default_value")
            {
                return BadRequest("Part is already assigned to this event.");
            }
            else
            {

            }

            // Ustaw pozostałe wartości
            existingEvent.Title = @event.Title;
            existingEvent.StartDate = @event.StartDate;
            existingEvent.EndDate = @event.EndDate;
            existingEvent.Serwisant = @event.Serwisant;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(existingEvent.Id))
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
        // PUT: api/Event/issue/{eventId}
        [HttpPut("issue/{eventId}")]
        public async Task<IActionResult> IssuePart(int eventId)
        {
            var @event = await _context.Event.FindAsync(eventId);

            if (@event == null)
            {
                return NotFound("Event not found.");
            }

            var part = await _context.Product.FirstOrDefaultAsync(p => p.name == @event.Part);

            if (part == null)
            {
                return BadRequest("Part associated with the event not found.");
            }

            if (part.stockquantity <= 0)
            {
                return BadRequest("No stock available for this part.");
            }

            

            // Ustawienie pola Part na 'default_value'
            @event.Part = "default_value";

            try
            {
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(eventId))
                {
                    return NotFound("Event not found.");
                }
                else
                {
                    throw;
                }
            }
        }
       // GET: api/Event/details
[HttpGet("details")]
public async Task<ActionResult<IEnumerable<EventDetailsViewModel>>> GetAllEventsDetails()
{
    var events = await _context.Event
        .Select(e => new EventDetailsViewModel
        {
            Title = e.Title,
            Status = e.Status,
            StartDate = e.StartDate,
            EndDate = e.EndDate,
            Serwisant = e.Serwisant
        })
        .ToListAsync();

    return Ok(events);
}
        // PUT: api/Event/updateserwisant/{eventId}
        [HttpPut("updateserwisant/{Id}")]
        public async Task<IActionResult> UpdateEventSerwisant(int Id, [FromBody] string serwisantUsername)
        {
            var @event = await _context.Event.FindAsync(Id);

            if (@event == null)
            {
                return NotFound("Event not found.");
            }

            @event.Serwisant = serwisantUsername;

            try
            {
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(Id))
                {
                    return NotFound("Event not found.");
                }
                else
                {
                    throw;
                }
            }
        }












        private bool EventExists(int id)
{
    return _context.Event.Any(e => e.Id == id);
}


        public class EventViewModel
        {
            public string Title { get; set; }
            public DateTime? StartDate { get; set; }
        }




    }
}
