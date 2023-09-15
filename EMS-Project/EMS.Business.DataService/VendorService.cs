

using AutoMapper;
using EMS.Business.Interfaces;
using EMS.Business.Models;
using EMS.Business.Services;
using EMS.Data;
using EMS.Data.Interfaces;

namespace EMS.Business.DataService
{
    public class VendorService : GenericService<VendorModel>, IVendorDataService
    {
        public VendorService(IUnitOfWork unitOfWork, IMapper mapper, EMSDbContext dbContext) : base(unitOfWork, mapper, dbContext)
        {
        }

        

    }
}
