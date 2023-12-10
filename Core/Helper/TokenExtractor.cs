using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper
{
    public class TokenExtractor
    {
        public static string Extractor(String bearerToken)
        {
            var token = bearerToken.Split(' ')[1];
            var handler = new JwtSecurityTokenHandler();
            var x = handler.ReadJwtToken(token);
            var jti = x.Claims.First(claim => claim.Type == "uid").Value;
            return jti;
        }
    }
}
