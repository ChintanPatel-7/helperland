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

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _helperlandContext.Users.Where(l => l.Email == email && l.Password == password).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _helperlandContext.Users.Where(l => l.Email == email).FirstOrDefault();
        }

        public User Update(User user)
        {
            _helperlandContext.Users.Update(user);
            _helperlandContext.SaveChanges();
            return user;
        }

        public User Add(User user)
        {
            _helperlandContext.Users.Add(user);
            _helperlandContext.SaveChanges();
            return user;
        }
    }
}
