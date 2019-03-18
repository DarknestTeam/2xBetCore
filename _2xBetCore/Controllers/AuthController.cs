using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2xBetCore.Data;
using _2xBetCore.Dtos;
using _2xBetCore.Interfaces;
using _2xBetCore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _2xBetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // GET: api/<controller>
        private readonly IUserGeneretic _repos;
        public AuthController(IUserGeneretic repository)
        {
            _repos = repository;
        }


        [HttpGet("{login}")]
        public ActionResult Login([FromBody]UserForLoginDTO userForLogin)
        {
            var user = _repos.Get(userForLogin.UserName.ToLower());
            if (user == null)
            {
                return Unauthorized();
            }


            return Ok();

        }

        //TODO: CalBack to Email
       public ActionResult Register([FromBody]UserForRegisterDTO userForRegister)
        {
            userForRegister.UserName = userForRegister.UserName.ToLower();

            if (_repos.Exists(userForRegister.UserName))
            {
                return BadRequest("Already have this user");
            }

            var CreateUser = new User
            {
                Login = userForRegister.UserName,
                Email = userForRegister.Email,
                Password = userForRegister.Password
            };

            var CreatedUser = _repos.Create(CreateUser);

            return StatusCode(201);
        }
       

    }
}

