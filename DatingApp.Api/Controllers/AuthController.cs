using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Api.models;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
//using DatingApp.Api.Models;

namespace DatingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        // // GET api/auth
        // [HttpGet("")]
        // public ActionResult<IEnumerable<string>> Getstrings()
        // {
        //     return new List<string> { };
        // }

        // // GET api/auth/5
        // [HttpGet("{id}")]
        // public ActionResult<string> GetstringById(int id)
        // {
        //     return null;
        // }

        // POST api/auth
        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            // TODO: Validate request
            username = username.ToLower();
            if (await _repo.UserExists(username))
                return BadRequest("Username already exists");
            
            var userToCreate = new User
            {
                UserName = username
            };

            var createdUser = await _repo.Register(userToCreate, password);
            // TODO: a route to Dashboard client
            return StatusCode(201);
        }

        // // PUT api/auth/5
        // [HttpPut("{id}")]
        // public void Putstring(int id, string value)
        // {
        // }

        // // DELETE api/auth/5
        // [HttpDelete("{id}")]
        // public void DeletestringById(int id)
        // {
        // }
    }
}