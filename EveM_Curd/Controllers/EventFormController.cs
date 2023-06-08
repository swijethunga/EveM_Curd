using EveM_Curd.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EveM_Curd.Models;
using Microsoft.EntityFrameworkCore;

namespace EveM_Curd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventFormController : ControllerBase
    {
        private readonly EventContext _dataContext;
        public EventFormController(EventContext eventdetailContext)
        {
            _dataContext = eventdetailContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventForm>>> GetEventFormData()
        {
            if (_dataContext.EventForms == null)
            {
                return NotFound();
            }

            return await _dataContext.EventForms.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<EventForm>> PostEventFormData(EventForm newEventForm)
        {
            await _dataContext.EventForms.AddAsync(newEventForm);
            _dataContext.SaveChanges();

            return await _dataContext.EventForms.Where(eForm => eForm.evTitle == newEventForm.evTitle).FirstOrDefaultAsync();
        }
    }
}
