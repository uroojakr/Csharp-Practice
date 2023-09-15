﻿using Event_Management_System.Models;

namespace Event_Management_System.Repositories.Interfaces
{
    public interface IVendorRepositories : IRepository<Vendor>
    {
        IEnumerable<Vendor> GetVendorsByName(string name);
    }
}