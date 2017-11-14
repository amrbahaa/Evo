using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Evo.Web.Api.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Evo.Web.Api.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Token")]
    public class TokenController : Controller
    {
        private IConfiguration _configuration;
        public TokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] TokenRequestViewModel request)
        {
            if (request.Username == request.Username && request.Password == request.Password)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, request.Username)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("TokenOptions:SigningKey").Value));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _configuration.GetSection("TokenOptions:Issuer").Value,
                    audience: _configuration.GetSection("TokenOptions:Audience").Value,
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