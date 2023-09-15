
using Microsoft.AspNetCore.Mvc;
using EMS.Data;
using Microsoft.EntityFrameworkCore;
using EMS.Data.Interfaces;

namespace EMSWebApi1.Controllers
{
    [Route("api/[controller]")] /* route template for api [eventcontroller] */
    [ApiController]
    public class EventsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork; //injecting IUnitOfWork

        public EventsController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Events /* retrieves */
        [HttpGet]
        public IActionResult GetEvents()
        {
          try
            {
                var events = _unitOfWork.EventRepository.GetAll();
                return Ok(events);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        // GET: api/Events/5    /* retreves by id */
        [HttpGet("{id}")]
      public IActionResult GetEvents(int id) 
        
        {
            try
            {
                var @event = _unitOfWork.EventRepository.GetById(id);
                if (@event == null)
                {
                    return NotFound();
                }
                return Ok(@event);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }


        // PUT: api/Events/5 /* modify response */
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutEvent(int id, Events updatedEvent)
        {
            try
            {
                var existingEvent = _unitOfWork.EventRepository.GetById(id);
                if (existingEvent == null)
                {
                    return NotFound();
                }

                existingEvent.Title = updatedEvent.Title;
                existingEvent.Description = updatedEvent.Description;
                existingEvent.Date = updatedEvent.Date;
                existingEvent.Location = updatedEvent.Location;


                _unitOfWork.EventRepository.Update(existingEvent);
                _unitOfWork.Commit();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/Events /* new response */
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostEvent(Events newEvent)
        {
            try
            {
                _unitOfWork.EventRepository.Add(newEvent);
                _unitOfWork.Commit();

                return CreatedAtAction(nameof(GetEvents), new { id = newEvent.EventId }, newEvent);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            try
            {
                var existingEvent = _unitOfWork.EventRepository.GetById(id);

                if (existingEvent == null)
                {
                    return NotFound();
                }
                _unitOfWork.EventRepository.Delete(id); 
                _unitOfWork.Commit(); 
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //private bool EventExists(int id) /* helper mthod returns bool to check whether exists or not */
        //{
        //    return (_context.Events?.Any(e => e.EventId == id)).GetValueOrDefault();
        //}
    }
}
