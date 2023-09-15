
using Microsoft.AspNetCore.Mvc;
using Event_Management_System.Models;
using EMS.Data.Interfaces;
using NUnit.Framework.Internal.Execution;

namespace EMSWebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Reviews
        [HttpGet]
        public ActionResult GetReviews()
        {
            try
            {
                var reviews = _unitOfWork.ReviewRepositories.GetAll();

                return Ok(reviews);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }


        // GET: api/Reviews/5
        [HttpGet("{id}")]
        public IActionResult GetReview(int id)
        {
            try
            {
                var @review = _unitOfWork.ReviewRepositories.GetById(id);
                if (@review == null)
                {
                    return NotFound();
                }
                return Ok(@review);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }


        // PUT: api/Reviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutReview(int id, Review updatedReview)
        {
            try
            {
                var existingReviews = _unitOfWork.ReviewRepositories.GetById(id);
                if (existingReviews == null)
                {
                    return NotFound();
                }

                existingReviews.Comment = updatedReview.Comment;
                existingReviews.Rating = updatedReview.Rating;

                _unitOfWork.ReviewRepositories.Update(existingReviews);
                _unitOfWork.Commit();
                return NoContent(); //successfully processed
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }


        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostReviews(Review newReviews)
        {
            try
            {
                _unitOfWork.ReviewRepositories.Add(newReviews);
                _unitOfWork.Commit();

                return CreatedAtAction(nameof(GetReview), new { id = newReviews.ReviewId }, newReviews);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            try
            {
                var review = _unitOfWork.ReviewRepositories.GetById(id);
                if (review == null)
                {
                    return NotFound();
                }
                                                                                                                                                                                                                            
                _unitOfWork.ReviewRepositories.Delete(id);
                _unitOfWork.Commit();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //private bool ReviewExists(int id)
        //{
        //    return (_context.Reviews?.Any(e => e.ReviewId == id)).GetValueOrDefault();
        //}
    }
}
