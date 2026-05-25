using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Mappings;
using SOSBackClean.Application.Services;
using SOSBackClean.Application.Services.FormularioServices;
using SOSBackClean.Data.Repositories;
using SOSBackClean.Domain.Entities;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/Creation")]
    public class Creation_formController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get() {
            return Ok(
                await EntryPoint.Provider()
                .GetRequiredService<IFormsCreationService>()
                .GetDataToForms()
                );
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateFormularioDTO dto) {
            await EntryPoint.Provider()
                .GetRequiredService<IFormsCreationService>()
                .CreateFormulario(dto);

            return Ok();
        }

    }
}
