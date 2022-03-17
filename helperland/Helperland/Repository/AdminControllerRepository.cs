using Helperland.Data;
using Helperland.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class AdminControllerRepository : IAdminControllerRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public AdminControllerRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        #region User

        public IEnumerable<User> GetUserList()
        {
            var users = _helperlandContext.Users;
            return users;
        }

        #endregion User

        #region ServiceRequest

        public IEnumerable<ServiceRequest> GetServiceRequestList()
        {
            var serviceRequests = _helperlandContext.ServiceRequests.Include(x => x.User).Include(x => x.ServiceProvider).Include(x => x.ServiceRequestAddresses).AsNoTracking();
            return serviceRequests;
        }

        #endregion ServiceRequest
    }
}
