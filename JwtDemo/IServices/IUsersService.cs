using JwtDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.IServices
{
    public interface IUsersService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
