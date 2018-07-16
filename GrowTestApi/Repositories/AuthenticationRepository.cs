using System.Collections.Generic;
using System.Linq;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly AuthenticationContext _context;

        public AuthenticationRepository(AuthenticationContext context)
        {
            _context = context;
        }

        public void CreateUser()
        {
            if (_context.AuthenticationItems.Count() == 0)
            {
                _context.AuthenticationItems.Add(new User { username = "userDev", password = "test123"});
                _context.AuthenticationItems.Add(new User { username = "userTest", password = "test123" });
                _context.SaveChanges();
            }
        }

        public bool Authentication(string userName, string password)
        {
            var isOkLogin = _context.AuthenticationItems.Where(b => b.username.Equals(userName) && b.password.Equals(password)).ToList();
            if (isOkLogin == null)
            {
                return false;
            }
            return true;
        }
    }
}
