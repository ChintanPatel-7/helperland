using Helperland.Data;
using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public UserRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        public List<User> GetUserByPostalCode(string postalCode)
        {
            return _helperlandContext.Users.Where(x => x.ZipCode == postalCode && x.IsApproved == true).ToList();
        }
    }
}
