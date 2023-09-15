
using Event_Management_System.Models;

namespace Event_Management_System.Repositories.Interfaces
{
    public interface IReviewRepositories : IRepository<Review>
    {
       IEnumerable<Review> GetReviewsByUserId(int userId);
        IQueryable<Review> GetReviewsByEventName();
        IEnumerable<Review> GetReviewsByVendorId(int VendorId);
        IQueryable<Review> getAllWithUsers();
    }
}
