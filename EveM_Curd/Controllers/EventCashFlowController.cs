using EveM_Curd.Data;
using EveM_Curd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.IdentityModel.Tokens;

namespace EveM_Curd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventCashFlowController : ControllerBase
    {
        private readonly EventContext _EventCashFlowContext;
        public EventCashFlowController(EventContext EventCashFlowContext)
        {
            _EventCashFlowContext = EventCashFlowContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventCashFlow>>> GetEventCashFlows()
        {
            if (_EventCashFlowContext.EventCashFlows == null)
            {
                return NotFound();
            }

            return await _EventCashFlowContext.EventCashFlows.ToListAsync();
        }

        [HttpGet("{Cex_id}")]

        public async Task<ActionResult<EventCashFlow>> GetEventCashFlow(int Cex_id)
        {
            if (_EventCashFlowContext.EventCashFlows == null)
            {
                return NotFound();
            }

            var EventCashFlow = await _EventCashFlowContext.EventCashFlows.FindAsync(Cex_id);

            if (EventCashFlow == null)
            {
                return NotFound();
            }

            return EventCashFlow;
        }

        [HttpPost]
        public async Task<ActionResult<EventCashFlow>> PostEventCashFlow(EventCashFlow EventCashFlow)
        {
            _EventCashFlowContext.EventCashFlows.Add(EventCashFlow);
            await _EventCashFlowContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEventCashFlow), new { Cex_id = EventCashFlow.Cex_id }, EventCashFlow);
        }

        [HttpPut("{Cex_id}")]
        public async Task<ActionResult> PutEventCashFlow(int Cex_id, EventCashFlow EventCashFlow)
        {
            //if (Income_id != EventCashFlow.Income_id)
            //{
            //    return BadRequest();
            //}

            //_EventCashFlowContext.Entry(EventCashFlow).State = EntityState.Modified;
            var cashflow = await _EventCashFlowContext.EventCashFlows.FindAsync(Cex_id);

            cashflow.Cex_date = EventCashFlow.Cex_date;
            cashflow.Cex_name = EventCashFlow.Cex_name;
            cashflow.Cex_amount = EventCashFlow.Cex_amount;

            _EventCashFlowContext.SaveChanges();

            //try
            //{
            //    await _EventCashFlowContext.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    throw;
            //}

            return Ok(cashflow);
        }

        [HttpDelete("{Cex_id}")]
        public async Task<ActionResult> DeleteEventCashFlow(int Cex_id)
        {
            if(_EventCashFlowContext.EventCashFlows == null)
            {
                return NotFound();
            }
            var EventCashFlow = await _EventCashFlowContext.EventCashFlows.FindAsync(Cex_id);

            if(EventCashFlow == null)
            {
                return NotFound();
            }

            _EventCashFlowContext.EventCashFlows.Remove(EventCashFlow);
            await _EventCashFlowContext.SaveChangesAsync();

            return Ok();
        }


    }
}
