using JwtDemo.IServices;
using JwtDemo.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JwtDemo.Services
{
    public class UserService : IUsersService, IAthorizationService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "John", LastName = "Smith", Username = "john", HashPassword = "12345", Phone = "555333222", Email = "john.smith@domain.com" }
        };

        public IEnumerable<User> Get()
        {
            // return users without passwords
            return _users.Select(x => {
                x.HashPassword = null;
                return x;
            });
        }

        public bool TryAthorize(string username, string password, out User user)
        {
            user = _users.SingleOrDefault(c => c.Username == username && c.HashPassword == password);

            user.HashPassword = null;

            return user != null;
        }
    }
}
