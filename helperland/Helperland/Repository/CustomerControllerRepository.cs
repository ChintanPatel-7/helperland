using Helperland.Data;
using Helperland.Enums;
using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class CustomerControllerRepository : ICustomerControllerRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public CustomerControllerRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        #region ServiceRequest Table
        public IEnumerable<ServiceRequest> GetCurrentServiceRequestByCustomerId(int customerId)
        {
            IEnumerable<ServiceRequest> serviceRequests = ((IEnumerable<ServiceRequest>)(from serviceRequest in _helperlandContext.ServiceRequests
                                                                                         join user in _helperlandContext.Users
                                                                                         on serviceRequest.ServiceProviderId equals user.UserId into serviceProvider
                                                                                         from sp in serviceProvider.DefaultIfEmpty()
                                                                                         where serviceRequest.ServiceStartDate > DateTime.Now && serviceRequest.UserId == customerId && 
                                                                                            serviceRequest.Status != (int)ServiceRequestStatusEnum.Cancelled && serviceRequest.Status != (int)ServiceRequestStatusEnum.Completed
                                                                                         select new ServiceRequest
                                                                                         {
                                                                                             ServiceRequestId = serviceRequest.ServiceRequestId,
                                                                                             UserId = serviceRequest.UserId,
                                                                                             ServiceStartDate = serviceRequest.ServiceStartDate,
                                                                                             ServiceHours = serviceRequest.ServiceHours,
                                                                                             ZipCode = serviceRequest.ZipCode,
                                                                                             ServiceHourlyRate = serviceRequest.ServiceHourlyRate,
                                                                                             ExtraHours = serviceRequest.ExtraHours,
                                                                                             SubTotal = serviceRequest.SubTotal,
                                                                                             Discount = serviceRequest.Discount,
                                                                                             Comments = serviceRequest.Comments,
                                                                                             SpacceptedDate = serviceRequest.SpacceptedDate,
                                                                                             HasPets = serviceRequest.HasPets,
                                                                                             Status = serviceRequest.Status,
                                                                                             CreatedDate = serviceRequest.CreatedDate,
                                                                                             ModifiedBy = serviceRequest.ModifiedBy,
                                                                                             ModifiedDate = serviceRequest.ModifiedDate,
                                                                                             RefundedAmount = serviceRequest.RefundedAmount,
                                                                                             TotalCost = serviceRequest.TotalCost,
                                                                                             HasIssue = serviceRequest.HasIssue,
                                                                                             PaymentDone = serviceRequest.PaymentDone,
                                                                                             PaymentDue = serviceRequest.PaymentDue,
                                                                                             ServiceProviderId = serviceRequest.ServiceProviderId,
                                                                                             RecordVersion = serviceRequest.RecordVersion,
                                                                                             User = sp,
                                                                                         }));
            return serviceRequests;
        }

        public ServiceRequest GetServiceRequest(int serviceRequestId)
        {
            ServiceRequest serviceRequest = _helperlandContext.ServiceRequests.Where(x => x.ServiceRequestId == serviceRequestId).FirstOrDefault();
            serviceRequest.ServiceRequestExtras = _helperlandContext.ServiceRequestExtras.Where(x => x.ServiceRequestId == serviceRequestId).ToList();
            serviceRequest.ServiceRequestAddresses = _helperlandContext.ServiceRequestAddresses.Where(x => x.ServiceRequestId == serviceRequestId).ToList();
            serviceRequest.User = _helperlandContext.Users.Where(x => x.UserId == serviceRequest.UserId).FirstOrDefault();
            return serviceRequest;
        }

        public List<ServiceRequest> GetFutureServiceRequestByServiceProviderId(int serviceProviderId)
        {
            List<ServiceRequest> serviceRequests = _helperlandContext.ServiceRequests.Where(x => x.ServiceProviderId == serviceProviderId && x.ServiceStartDate > DateTime.Now).ToList();
            return serviceRequests;
        }

        public ServiceRequest UpdateServiceRequest(ServiceRequest serviceRequest)
        {
            _helperlandContext.ServiceRequests.Update(serviceRequest);
            _helperlandContext.SaveChanges();
            return serviceRequest;
        }

        #endregion ServiceRequest Table

        #region Rating Table

        public List<Rating> GetRatingsByServiceProviderId(int? serviceProviderId)
        {
            return _helperlandContext.Ratings.Where(x => x.RatingTo == serviceProviderId).ToList<Rating>();
        }

        #endregion Rating Table

        #region User Table

        public User GetUserByPK(int userId)
        {
            return _helperlandContext.Users.Where(x => x.UserId == userId).FirstOrDefault();
        }

        #endregion User Table

    }
}
