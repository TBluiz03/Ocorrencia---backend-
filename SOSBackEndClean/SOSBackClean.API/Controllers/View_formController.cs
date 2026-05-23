using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Domain.Entities;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/View")]
    public class View_formController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await EntryPoint.TesteServices().GetFormsItems());
        }

        [HttpGet("Details")]
        public async Task<IActionResult> GetDetails(string protocolo)
        {
            return Ok(await EntryPoint.TesteServices().GetFormDetails(protocolo));
        }
        


    }
}
