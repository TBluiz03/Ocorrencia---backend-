using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs.Formulario;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Services.FormularioServices;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/Manegement")]
    public class Management_formController : Controller
    {
        private readonly IFormsManegementService _formsManegementService;

        public Management_formController(IFormsManegementService formsManegementService)
        {
            _formsManegementService = formsManegementService;
        }

        [HttpPatch]
        public async Task<IActionResult> Patch(ResolveFormularioDTO dto)
        {
            return Ok(await _formsManegementService.ResolveForm(dto));
        }
    }
}
