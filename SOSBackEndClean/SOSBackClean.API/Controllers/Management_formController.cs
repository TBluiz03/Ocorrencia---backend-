using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Services.FormularioServices;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/Manegement")]
    public class Management_formController : Controller
    {
        [HttpPatch]
        public async Task<IActionResult> Patch(ResolveFormularioDTO dto)
        {
            
            return Ok(await EntryPoint.Provider()
                .GetRequiredService<IFormsManegementService>()
                .ResolveForm(dto)
                );
        }
    }
}
