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
        public void Login([FromBody]string username)
        {
            var user = _repos.Get(username);

        }
        // Чисто для проверки,все работает :3
        [HttpGet("{getall}")]
        public User GetSmth(string username)
        {
            var td = _repos.Get(username);
            return td;
        }

    }
}

