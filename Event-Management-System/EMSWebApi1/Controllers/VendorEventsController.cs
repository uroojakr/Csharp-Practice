//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Event_Management_System.Models;
//using EMS.Data.Interfaces;

//namespace EMSWebApi1.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class VendorEventsController : ControllerBase
//    {
//        private readonly IUnitOfWork _unitOfWork;

//        public VendorEventsController(IUnitOfWork unitOfWork)
//        {
//            _unitOfWork = unitOfWork;
//        }

//        // GET: api/VendorEvents
//        [HttpGet]
//        public IActionResult GetVendorEvent()
//        {
//            try
//            {
//                var vendors = _unitOfWork.VendorEventRepositories.GetAll();
//                return Ok(vendors);
//            }
//            catch (Exception ex) 
//            {
//                return StatusCode(500, $"Internal Server Error: {ex.Message}");
//            }
//        }

//        // GET: api/VendorEvents/5
//        [HttpGet("{id}")]
//        public IActionResult GetVendorEvent(int id)
//        {
//            try
//            {
//                var @vendor = _unitOfWork.VendorEventRepositories.GetById(id);
//                if(@vendor == null) 
//                {
//                    return NotFound();
//                }
//                return Ok(@vendor);
//            }
//            catch (Exception ex) 
//            {
//                return StatusCode(500, $"Internal server error:{ex.Message}");
//            }
//        }

//        // PUT: api/VendorEvents/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPut("{id}")]
//        public IActionResult PutVendorEvent(int id, VendorEvent updatedVendorEvent)
//        {
//            try
//            {
//                var existingVendorEvent = _unitOfWork.VendorEventRepositories.GetById(id);
//                if (existingVendorEvent == null)
//                {
//                    return NotFound();
//                }

//                existingVendorEvent.EventId = updatedVendorEvent.EventId;

//                _unitOfWork.ReviewRepositories.Update(existingVendorEvent);
//                _unitOfWork.Commit();
//                return NoContent(); //successfully processed
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, $"Internal server error:{ex.Message}");
//            }
//        }

//        // POST: api/VendorEvents
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<VendorEvent>> PostVendorEvent(VendorEvent vendorEvent)
//        {
//          if (_context.VendorEvent == null)
//          {
//              return Problem("Entity set 'EventManagementContext.VendorEvent'  is null.");
//          }
//            _context.VendorEvent.Add(vendorEvent);
//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateException)
//            {
//                if (VendorEventExists(vendorEvent.VendorId))
//                {
//                    return Conflict();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return CreatedAtAction("GetVendorEvent", new { id = vendorEvent.VendorId }, vendorEvent);
//        }

//        // DELETE: api/VendorEvents/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteVendorEvent(int id)
//        {
//            if (_context.VendorEvent == null)
//            {
//                return NotFound();
//            }
//            var vendorEvent = await _context.VendorEvent.FindAsync(id);
//            if (vendorEvent == null)
//            {
//                return NotFound();
//            }

//            _context.VendorEvent.Remove(vendorEvent);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool VendorEventExists(int id)
//        {
//            return (_context.VendorEvent?.Any(e => e.VendorId == id)).GetValueOrDefault();
//        }
//    }
//}
