using System.Reflection.Metadata;
using EveM_Curd.Data;
using EveM_Curd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace EveM_Curd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventExpenseController : ControllerBase
    {
        private readonly EventContext _eventexpenseContext;
        public EventExpenseController(EventContext eventexpenseContext)
        {
            _eventexpenseContext = eventexpenseContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventExpense>>> GetEventExpenses()
        {
            if (_eventexpenseContext.EventExpenses == null)
            {
                return NotFound();
            }

            return await _eventexpenseContext.EventExpenses.ToListAsync();
        }

        [HttpGet("{Transac_id}")]

        public async Task<ActionResult<EventExpense>> GetEventExpense(int Transac_id)
        {
            if (_eventexpenseContext.EventExpenses == null)
            {
                return NotFound();
            }

            var eventexpense = await _eventexpenseContext.EventExpenses.FindAsync(Transac_id);

            if (eventexpense == null)
            {
                return NotFound();
            }

            return eventexpense;
        }

        [HttpPost]
        public async Task<ActionResult<EventExpense>> PostEventExpense(EventExpense eventexpense)
        {
            _eventexpenseContext.EventExpenses.Add(eventexpense);
            await _eventexpenseContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEventExpense), new { Transac_id = eventexpense.Transac_id }, eventexpense);
        }

        [HttpPut("{Transac_id}")]
        public async Task<ActionResult> PutEventExpense(int Transac_id, EventExpense eventexpense)
        {
            /*if (Transac_id != eventexpense.Transac_id)
            {
                return BadRequest();
            }

            _eventexpenseContext.Entry(eventexpense).State = EntityState.Modified;

            try
            {
                await _eventexpenseContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }*/

            var expense = await _eventexpenseContext.EventExpenses.FindAsync(Transac_id);

            expense.Transac_date = eventexpense.Transac_date;
            expense.Transac_name = eventexpense.Transac_name;
            expense.Transac_amount = eventexpense.Transac_amount;
            expense.Transac_type = eventexpense.Transac_type;

            _eventexpenseContext.SaveChanges();

            return Ok(expense);
        }

        [HttpDelete("{Transac_id}")]
        public async Task<ActionResult> DeleteEventExpense(int Transac_id)
        {
            if (_eventexpenseContext.EventExpenses == null)
            {
                return NotFound();
            }
            var eventexpense = await _eventexpenseContext.EventExpenses.FindAsync(Transac_id);

            if (eventexpense == null)
            {
                return NotFound();
            }

            _eventexpenseContext.EventExpenses.Remove(eventexpense);
            await _eventexpenseContext.SaveChangesAsync();

            return Ok();
        }

        




    }
}
