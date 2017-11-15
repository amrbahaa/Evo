using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Evo.Security.Jwt;
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
        //private IConfiguration _configuration;
        private readonly IJwtTokenIssuer _jwtTokenIssuer;
        public TokenController(IConfiguration configuration, IJwtTokenIssuer jwtTokenIssuer)
        {
            //_configuration = configuration;
            _jwtTokenIssuer = jwtTokenIssuer;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] TokenRequestViewModel request)
        {
            if (request.Username == request.Username && request.Password == request.Password)
            {
                var token = _jwtTokenIssuer.CreateToken(request.Username);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }

            return BadRequest("Could not verify username and password");
        }
    }
}