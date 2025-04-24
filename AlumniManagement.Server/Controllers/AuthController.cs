using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AlumniManagement.Server.Models;
using BCrypt.Net;

namespace AlumniManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserContext _context;

        public AuthController(UserContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            // Retrieve the user from the database
            var user = await _context.User
                .FirstOrDefaultAsync(u => u.Email == login.Email);

            if (user == null)
            {
                return Unauthorized("Invalid credentials");
            }

            // Here, use a password hash verification (e.g., using BCrypt or ASP.NET Identity)
            if (!BCrypt.Net.BCrypt.Verify(login.Password, user.Password)) // Use BCrypt to verify hashed password
            {
                return Unauthorized("Invalid credentials");
            }

            // Create JWT token
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.ID.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSuperSecretKey"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "YourIssuer",
                audience: "YourAudience",
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }

}
