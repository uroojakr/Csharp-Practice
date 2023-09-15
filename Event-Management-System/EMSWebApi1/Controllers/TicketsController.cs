
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Event_Management_System.Models;
using EMS.Data.Interfaces;
using System.Linq.Expressions;

namespace EMSWebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TicketsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Tickets
        [HttpGet]
        public ActionResult GetTicket()
        {
            try
            {
                var ticket = _unitOfWork.TicketRepositories.GetAll();
                if (ticket == null)
                {
                    return NotFound();
                }
                return Ok(ticket);
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public IActionResult GetTicket(int id)
        {
            try
            {
                var @Ticket = _unitOfWork.TicketRepositories.GetById(id);
                if (@Ticket == null)
                {
                    return NotFound();
                }
                return Ok(@Ticket);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
            }


        // PUT: api/Tickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutTicket(int id, Ticket updatedTicket)
        {
            try
            {
                var existingTickets = _unitOfWork.TicketRepositories.GetById(id);
                if (existingTickets == null)
                {
                    return NotFound();
                }
                existingTickets.UserId = updatedTicket.UserId;
                existingTickets.EventId = updatedTicket.EventId;

                _unitOfWork.Commit();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        // POST: api/Tickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostTicket(Ticket newTicket)
        {
            try
            {
                _unitOfWork.TicketRepositories.Add(newTicket);
                _unitOfWork.Commit();

                return CreatedAtAction(nameof(GetTicket), new { id = newTicket.TickerId }, newTicket);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            try
            {
                var ticket = _unitOfWork.TicketRepositories.GetById(id);
                if (ticket == null)
                {
                    return NotFound();
                }

                _unitOfWork.TicketRepositories.Delete(id);
                _unitOfWork.Commit();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
