using JwtDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.IServices
{

    public interface IUsersService
    {
        bool TryAthorize(string username, string password, out User user);
        IEnumerable<User> Get();
    }
}
