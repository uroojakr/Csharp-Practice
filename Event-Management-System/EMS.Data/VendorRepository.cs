using Event_Management_System.Models;
using Event_Management_System.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Repositories.Services
{
    public class VendorRepository : Repository<Vendor> , IVendorRepositories
    {
        private readonly DbContext _context;
        public VendorRepository(EventManagementContext context) : base(context) => _context = context;

        public IEnumerable<Vendor> GetVendorsByName(string name) => _context.Set<Vendor>().Where(v => v.Name == name).ToList();
    }
}
