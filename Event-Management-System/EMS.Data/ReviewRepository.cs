using Event_Management_System.Models;
using Event_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Repositories.Services
{
 
        public class ReviewRepository : Repository<Review>, IReviewRepositories
        {
            private readonly DbContext _context;
            public ReviewRepository(EventManagementContext context) : base(context) => _context = context;

            public IQueryable<Review> GetReviewsByEventName() => _context.Set<Review>().Include(r => r.Event);

            public IEnumerable<Review> GetReviewsByUserId(int userId) => _context.Set<Review>().Where(ru => ru.UserId == userId);

            public IEnumerable<Review> GetReviewsByVendorId(int VendorId)
            {
                int vID = VendorId;
                return _context.Set<Review>().Where(rv => rv.VendorId.Equals(vID)).ToList();
            }
         
    }
    
}
