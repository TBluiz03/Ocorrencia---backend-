using SOSBackClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record CreateFormularioDataDTO
    {
        //Nesse DTO teremos o envio no verbo GET para o front-end
        //da lista de predios do DB e dos funcionários.

        public IEnumerable<PredioDTO> Predios {  get; set; }

        public IEnumerable<FuncionarioDTO> Funcionarios { get; set; }
    }
}
