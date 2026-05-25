using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Services.FormularioServices;
using SOSBackClean.Domain.Entities;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/View")]
    public class View_formController : Controller
    {
        private readonly IFormsQueryService _formsQueryService;

        public View_formController(IFormsQueryService formsQueryService)
        {
            _formsQueryService = formsQueryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _formsQueryService.GetFormsItems());
        }

        [HttpGet("Details")]
        public async Task<IActionResult> GetDetails(string protocolo)
        {
            return Ok(await _formsQueryService.GetFormDetails(protocolo));
        }
        


    }
}
