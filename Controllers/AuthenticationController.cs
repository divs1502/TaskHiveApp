using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskHiveSyncs.Models;
using TaskHiveSyncs.Services;

namespace TaskHiveSyncs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;

        public AuthenticationController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto loginDto)
        {
            var token = await _authenticationService.AuthenticateAsync(loginDto.Email, loginDto.Password);

            if (token == null)
            {
                return Unauthorized("Invalid credentials.");
            }

            return Ok(new { Token = token });
        }

        public class UserLoginDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
