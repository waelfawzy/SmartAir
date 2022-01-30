using AutoMapper;
using BLL.IRepositories;
using DAL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SmartAir_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepo repository;
        private readonly IConfiguration _config;


        public UserController(IUserRepo repository, IConfiguration config)
        {
            this.repository = repository;
            _config = config;
        }
        [HttpPost("{action}")]
        public async Task<ActionResult<IEnumerable<AuthenticateResponse>>> Login(AuthenticateRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid client request");
            }
            request.SecretKey= _config["AppSettings:SecretKey"];
            var user = await repository.Authenticate(request);
            if (user == null)
                return Unauthorized("User Email or Password is not Correct");
            return Ok(user);
        }

        [Authorize]
        [HttpGet("{action}")]
        public string Test()
        {
            return "Authorization Work fine";
        }
        [HttpGet("{action}")]

        public async Task<ActionResult<IEnumerable<TokenVM>>> RefreshToken(TokenVM request)
        {
            if (request == null)
            {
                return BadRequest("Invalid client request");
            }
            request.SecretKey = _config["AppSettings:SecretKey"];
            var TokenResponse = await repository.Refresh(request);
            if (TokenResponse == null)
                return Unauthorized("Invalid client request");
            return Ok(TokenResponse);
        }

        }
    }
