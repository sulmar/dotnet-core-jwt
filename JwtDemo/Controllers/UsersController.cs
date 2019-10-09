using JwtDemo.IServices;
using JwtDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;
        
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult GenerateToken([FromServices] ITokenService tokenService, [FromBody] User userParam)
        {
           if (_usersService.TryAthorize(userParam.Username, userParam.HashPassword, out User user))
           {
                user.Token = tokenService.CreateToken(user);

                return Ok(user);
           }

            else
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
               

           
        }
    }
}
