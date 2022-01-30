using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SL.TokenManger
{
  public  interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims, string SecretKey);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token,string SecretKey);
    }
}
