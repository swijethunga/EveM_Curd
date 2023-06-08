using EveM_Curd.Data;
using EveM_Curd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EveM_Curd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorDetailController : ControllerBase
    {
        private readonly EventContext _vendordetailContext;

        public VendorDetailController(EventContext vendordetailContext)
        {
            _vendordetailContext = vendordetailContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendorDetail>>> GetVendorDetails()
        {
            if (_vendordetailContext.VendorDetails == null)
            {
                return NotFound();
            }

            return await _vendordetailContext.VendorDetails.ToListAsync();
        }

        [HttpGet("{Vendor_id}")]

        public async Task<ActionResult<VendorDetail>> GetVendorDetail(int Vendor_id)
        {
            if (_vendordetailContext.EventDetails == null)
            {
                return NotFound();
            }

            var vendordetail = await _vendordetailContext.VendorDetails.FindAsync(Vendor_id);

            if (vendordetail == null)
            {
                return NotFound();
            }

            return vendordetail;
        }

        [HttpPost]
        public async Task<ActionResult<VendorDetail>> PostEventExpense(VendorDetail vendordetail)
        {
            _vendordetailContext.VendorDetails.Add(vendordetail);
            await _vendordetailContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVendorDetail), new { Vendor_id = vendordetail.Vendor_id }, vendordetail);
        }

        [HttpPut("{Vendor_id}")]
        public async Task<ActionResult> PutVendorDetail(int Vendor_id, VendorDetail vendordetail)
        {
            /*if (Expense_id != eventexpense.Expense_id)
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

            var vendor = await _vendordetailContext.VendorDetails.FindAsync(Vendor_id);

            vendor.Vendor_name = vendordetail.Vendor_name;
            vendor.Contact_person = vendordetail.Contact_person;
            vendor.Contact_no = vendordetail.Contact_no;
            vendor.Contact_email = vendordetail.Contact_email;
            vendor.Service_offered = vendordetail.Service_offered;
            vendor.Add_info = vendordetail.Add_info;

            _vendordetailContext.SaveChanges();

            return Ok(vendor);
        }

        [HttpDelete("{Vendor_id}")]
        public async Task<ActionResult> DeleteVendorDetail(int Vendor_id)
        {
            if (_vendordetailContext.VendorDetails == null)
            {
                return NotFound();
            }
            var vendordetail = await _vendordetailContext.VendorDetails.FindAsync(Vendor_id);

            if (vendordetail == null)
            {
                return NotFound();
            }

            _vendordetailContext.VendorDetails.Remove(vendordetail);
            await _vendordetailContext.SaveChangesAsync();

            return Ok();
        }
    }
}
