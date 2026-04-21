using ConsultaHub.Models.Entities;
using ConsultaHub.View.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user { get; set; } = new();

        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            var hassedPassword = new PasswordHasher<User>()
                .HashPassword(user, request.Password);

            user.Username = request.Username;
            user.PasswordHash = hassedPassword;

            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<string> Login(UserDto request)
        {
            if (user.Username != request.Username)
                return BadRequest("Usuário não encontrado.");
            var result = new PasswordHasher<User>()
                .VerifyHashedPassword(user, user.PasswordHash, request.Password);
            if (result == PasswordVerificationResult.Failed)
                return BadRequest("Senha incorreta.");

            string token = "success";
            return Ok(token);
        }
    }
}
