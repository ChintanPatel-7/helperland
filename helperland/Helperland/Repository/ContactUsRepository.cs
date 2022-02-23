using Helperland.Data;
using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public ContactUsRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        public ContactU Add(ContactU contactU)
        {
            _helperlandContext.ContactUs.Add(contactU);
            _helperlandContext.SaveChanges();
            return contactU;
        }
    }
}
