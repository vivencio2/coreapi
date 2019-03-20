using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;

namespace api.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken(string username, string password)
        {
            if (username == "assessment" && password == "p4s$M3P15")
            {
                var claims = new[]{ new Claim(ClaimTypes.Name, username) };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("12345678901234567"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "orsted.dk",
                    audience: "orsted.dk",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                return Ok(new
                {
                    
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }

            return BadRequest("Could not verify username and password");
        }
    }
}