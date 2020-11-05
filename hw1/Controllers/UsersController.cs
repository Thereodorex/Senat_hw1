using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hw1.Models;

namespace hw1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            User[] users = {
                new User()
                {
                    Id = 0,
                    FirstName = "Fedor",
                    LastName = "Malkov",
                    Login = "jcorwin",
                    Password = "notHiddenPassword"
                },
                new User()
                {
                    Id = 1,
                    FirstName = "username1",
                    LastName = "secondame1",
                    Login = "login1",
                    Password = "password1"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "username2",
                    LastName = "secondame2",
                    Login = "login2",
                    Password = "password2"
                }

            };
            if (id < 0 && id >= users.Length)
            {
                return NotFound();
            }
            return Ok(users[id]);
        }
    }
}