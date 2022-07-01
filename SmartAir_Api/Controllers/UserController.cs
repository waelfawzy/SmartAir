using AutoMapper;
using BLL.IRepositories;
using DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SmartAir_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        private readonly IRepoWrapper repository;
        private readonly IConfiguration _config;


        public UserController(IRepoWrapper repository, IConfiguration config)
        {
            this.repository = repository;
            _config = config;
        }
        [HttpPost("Login")]
        public async Task<ActionResult<IEnumerable<AuthenticateResponse>>> Login(AuthenticateRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid client request");
            }
            request.SecretKey= _config["AppSettings:SecretKey"];
            var user = await repository._User.Authenticate(request);
            if (user == null)
                return Unauthorized("User Email or Password is not Correct");
            return Ok(user);
        }

        
        [HttpGet("[action]")]
        public string Test()
        {
            return "Authorization Work fine";
        }

        [HttpPost("RefreshToken")]
        public async Task<ActionResult<IEnumerable<TokenVM>>> RefreshToken(TokenVM request)
        {
            if (request == null)
            {
                return BadRequest("Invalid client request");
            }
            request.SecretKey = _config["AppSettings:SecretKey"];
            var TokenResponse = await repository._User.Refresh(request);
            if (TokenResponse == null)
                return Unauthorized("Invalid client request");
            return Ok(TokenResponse);
        }

        }
    }
