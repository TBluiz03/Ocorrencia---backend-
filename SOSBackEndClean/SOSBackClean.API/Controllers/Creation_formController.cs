using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Domain.Entities;

namespace SOSBackClean.API.Controllers
{
    [ApiController]
    [Route("Api/Creation")]
    public class Creation_formController : Controller
    {


        [HttpGet]
        public async Task<IActionResult> Get() {

            var predio = new Predio(5, "Predio Norte");
            var predio2 = new Predio(3, "Predio Sul");

            var funcionario = new Funcionario("Joao", "httmml//as1293$#44?", Domain.ValueObjects.CARGO.SECRETARIO);
            var funcionario2 = new Funcionario("Maria", "httmml/12311293$#44?", Domain.ValueObjects.CARGO.ENFERMEIRO);

            var listaPredio = new List<Predio>() { predio, predio2 };
            var listaFuncio = new List<Funcionario>() {  funcionario, funcionario2 };

            var DTO = new CreateFormularioDataDTO{
                predios = listaPredio,
                funcionarios = listaFuncio,
            };

            return Ok(DTO);
            
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateFormularioDTO Dto) {

            return Ok(Dto);
        }

    }
}
