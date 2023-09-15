using EMS.Data.Interfaces;
using Event_Management_System.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Business.DataServices
{
    public class EventServices : GenericService<Events>
    {
        public EventServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }
}
