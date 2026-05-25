using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs.Formulario;
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
        private readonly IFormsCreationService _formsCreationService;

        public Creation_formController(IFormsCreationService formsCreationService)
        {
            _formsCreationService = formsCreationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            return Ok(
                await _formsCreationService
                .GetDataToForms()
                );
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateFormularioDTO dto) {
            await _formsCreationService
                .CreateFormulario(dto);

            return Ok();
        }

    }
}
