using Helperland.Data;
using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class ServiceRequestExtraRepository : IServiceRequestExtraRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public ServiceRequestExtraRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        public ServiceRequestExtra Add(ServiceRequestExtra serviceRequestExtra)
        {
            _helperlandContext.ServiceRequestExtras.Add(serviceRequestExtra);
            _helperlandContext.SaveChanges();
            return serviceRequestExtra;
        }
    }
}
