using BLL.IRepositories;
using DAL.Models;
using DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SL.TokenManger;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        private readonly SmartContext _context;
        private readonly AppSettings _appSettings;
        readonly ITokenService tokenService;


        public UserRepo(SmartContext context, IOptions<AppSettings> appSettings, ITokenService tokenService) : base(context)
        {
            this._context = context;
            _appSettings = appSettings.Value;
            this.tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        }
        public UserRepo(SmartContext context) : base(context)
        {
            this._context = context;
        }
       
        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
           var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == model.Email && x.Password == model.Password && x.Active==true);
           // var user =  users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password && x.Active == true);

            // return null if user not found
            if (user == null) return null;

              var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, model.Email)
        };

            // authentication successful so generate jwt token
            var token = tokenService.GenerateAccessToken(claims,model.SecretKey); // generateJwtToken(user);
            var RefreshToken = tokenService.GenerateRefreshToken();
            user.RefreshToken = RefreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

            _context.SaveChanges();
            return new AuthenticateResponse(user, token);
        }

        public async Task<TokenVM> Refresh(TokenVM tokenApiModel)
        {
           
            string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;
            var principal = tokenService.GetPrincipalFromExpiredToken(accessToken,tokenApiModel.SecretKey);
            var Email = principal.Claims.Where(e => e.Type.Contains("emailaddress"))
                   .Select(e => e.Value).SingleOrDefault(); //this is mapped to the Email claim by default
            var user = _context.Users.SingleOrDefault(u => u.Email == Email);
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return null;
            }
            var newAccessToken = tokenService.GenerateAccessToken(principal.Claims,tokenApiModel.SecretKey);
            var newRefreshToken = tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;
            _context.SaveChanges();
            return new TokenVM()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            };
        }
      
    }
}
