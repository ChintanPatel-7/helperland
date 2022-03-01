using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public interface ICustomerControllerRepository
    {
        //ServiceRequest Table
        IEnumerable<ServiceRequest> GetCurrentServiceRequestByCustomerId(int customerId);

        ServiceRequest GetServiceRequest(int serviceRequestId);

        List<ServiceRequest> GetFutureServiceRequestByServiceProviderId(int serviceProviderId);

        ServiceRequest UpdateServiceRequest(ServiceRequest serviceRequest);

        //Rating Table
        List<Rating> GetRatingsByServiceProviderId(int? serviceProviderId);

        //User Table

        User GetUserByPK(int userId);
    }
}
