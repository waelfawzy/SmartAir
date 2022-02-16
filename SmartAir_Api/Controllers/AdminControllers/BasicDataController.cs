using BLL.IRepositories;
using BLL.Response_VM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartAir_Api.StatusCodes;

namespace SmartAir_Api.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicDataController : Controller
    {
        private readonly IRepoWrapper repo;

        public BasicDataController(IRepoWrapper _repo)
        {
            repo = _repo;
        }
        //********************************Countries CRUD OPERTION*****************************//
        [HttpGet]
        [Route("DisplayAllCountries")]
        public JsonResult CountryList()
        {
            Response_VM response_VM = new Response_VM();
            var countries= repo._Country.GetAll().Result.Select(s => new { s.Id, s.Name, s.InsertionDate }).ToList();
            response_VM = new Response_VM() { Data = countries, StatusCode = 200, Message = CustomeStatusCodes.ErrorCodes[200] };
            return Json(response_VM);
        }
    }
}
