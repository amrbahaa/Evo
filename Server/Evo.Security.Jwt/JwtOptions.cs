using System;
using System.Collections.Generic;
using System.Text;

namespace Evo.Security.Jwt
{
    public class JwtOptions
    {
        public string Audience;
        public string Issuer;
        public string SigningKey;
    }
}
