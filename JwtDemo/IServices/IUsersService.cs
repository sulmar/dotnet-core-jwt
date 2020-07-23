using JwtDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.IServices
{

    public interface IUsersService
    {
        IEnumerable<User> Get();
    }
}
