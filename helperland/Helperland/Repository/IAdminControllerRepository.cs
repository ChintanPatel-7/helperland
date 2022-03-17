using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public interface IAdminControllerRepository
    {
        //User Table
        IEnumerable<User> GetUserList();

        //ServiceRequest Table
        IEnumerable<ServiceRequest> GetServiceRequestList();
    }
}
