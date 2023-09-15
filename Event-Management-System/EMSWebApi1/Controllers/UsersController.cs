using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Event_Management_System.Models;
using EMS.Data.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace EMSWebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Users
        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var reviews = _unitOfWork.UserRepositories.GetAll();

                return Ok(reviews);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            try
            {
                var @user = _unitOfWork.UserRepositories.GetById(id);
                if (@user == null)
                {
                    return NotFound();
                }
                return Ok(@user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutUser(int id, User updatedUser)
        {
            try
            {
                var existingUser = _unitOfWork.UserRepositories.GetById(id);
                if (existingUser == null)
                {
                    return NotFound();
                }

                existingUser.UserName = updatedUser.UserName;
                existingUser.Password = updatedUser.Password;
                existingUser.Email = updatedUser.Email;

                _unitOfWork.UserRepositories.Update(existingUser);
                _unitOfWork.Commit();
                return NoContent(); //successfully processed
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult PostUser(User newUser)
        {
            try
            {
                _unitOfWork.UserRepositories.Add(newUser);
                _unitOfWork.Commit();

                return CreatedAtAction(nameof(GetUser), new { id = newUser.UserId }, newUser);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                var delete = _unitOfWork.UserRepositories.GetById(id);
                if (delete == null)
                {
                    return NotFound();
                }

                _unitOfWork.UserRepositories.Delete(id);
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
