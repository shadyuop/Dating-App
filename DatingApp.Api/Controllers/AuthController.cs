using System.Threading.Tasks;
using DatingApp.Api.Dtos;
using DatingApp.Api.models;
using DatingApp.Api.Data;
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

        // POST api/auth/register
[HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.UserName = userForRegisterDto.UserName.ToLower();

            if (await _repo.UserExists(userForRegisterDto.UserName))
                return BadRequest("UserName already exists");

            var userToCreate = new User
            {
                UserName = userForRegisterDto.UserName
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

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