using System.Linq;
using YourNamespace.Data;
using YourNamespace.Models;

namespace YourNamespace.Services
{
    public interface IUserService
    {
        Users Authenticate(string username, string password);
        
    }

    public class UserService : IUserService
    {
        private readonly YourDbContext _context;


        public UserService(YourDbContext context)
        {
            _context = context;
        }

        public Users Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.Users.SingleOrDefault(x => x.username == username && x.password == password);

            // Check if user exists with given username and password
            if (user == null)
                return null;

            // Authentication successful, return user object
            return user;
        }
    }
}
