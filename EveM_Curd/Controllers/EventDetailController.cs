using EveM_Curd.Data;
using EveM_Curd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EveM_Curd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventDetailController : ControllerBase
    {
        private readonly EventContext _eventdetailContext;
        public EventDetailController(EventContext eventdetailContext)
        {
            _eventdetailContext = eventdetailContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDetail>>> GetEventDetails()
        {
            if (_eventdetailContext.EventDetails == null)
            {
                return NotFound();
            }

            return await _eventdetailContext.EventDetails.ToListAsync();
        }

        [HttpGet("{Event_id}")]

        public async Task<ActionResult<EventDetail>> GetEventDetail(int Event_id)
        {
            if (_eventdetailContext.EventDetails == null)
            {
                return NotFound();
            }

            var eventdetail = await _eventdetailContext.EventDetails.FindAsync(Event_id);

            if (eventdetail == null)
            {
                return NotFound();
            }

            return eventdetail;
        }

        [HttpPost]
        public async Task<ActionResult<EventDetail>> PostEventDetail(EventDetail eventdetail)
        {
            _eventdetailContext.EventDetails.Add(eventdetail);
            await _eventdetailContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEventDetail), new { Event_id = eventdetail.Event_id }, eventdetail);
        }

        [HttpPut("{Event_id}")]
        public async Task<ActionResult> PutEventDetail(int Event_id, EventDetail eventdetail)
        {
            if (Event_id != eventdetail.Event_id)
            {
                return BadRequest();
            }

            _eventdetailContext.Entry(eventdetail).State = EntityState.Modified;

            try
            {
                await _eventdetailContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok();
        }

        [HttpDelete("{Event_id}")]
        public async Task<ActionResult> DeleteEventDetail(int Event_id)
        {
            if (_eventdetailContext.EventDetails == null)
            {
                return NotFound();
            }
            var eventdetail = await _eventdetailContext.EventExpenses.FindAsync(Event_id);

            if (eventdetail == null)
            {
                return NotFound();
            }

            _eventdetailContext.EventExpenses.Remove(eventdetail);
            await _eventdetailContext.SaveChangesAsync();

            return Ok();
        }
    }
}
