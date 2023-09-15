

using AutoMapper;
using EMS.Business.Interfaces;
using EMS.Business.Models;
using EMS.Business.Services;
using EMS.Data;
using EMS.Data.Interfaces;
using EMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EMS.Business.DataService
{
    public class VendorEventService : GenericService<VendorEventModel>, IVendorEventService
    {
        public VendorEventService(IUnitOfWork unitOfWork, IMapper mapper, EMSDbContext dbContext) : base(unitOfWork, mapper, dbContext)
        {
        }
        public async Task<IEnumerable<VendorEventModel>> GetVendorEventsByEventTitleWithInclude(string eventTitle)
        {
            var query = _dbContext.VendorEvents
                .Where(ve => ve.Event.Title == eventTitle)
                .Include(ve => ve.Vendor)
                .Include(ve => ve.Event);

            var vendorEvents = await query.ToListAsync();
            var vendorEventModels = _mapper.Map<IEnumerable<VendorEventModel>>(vendorEvents);
            return vendorEventModels;
        }



    }
}
