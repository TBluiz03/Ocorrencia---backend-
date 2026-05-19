using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record FormularioDetailsDTO
    {
        public string? Ofendido { get; set; }
        public string? sala { get; set; }
        public int Andar { get; set; }
        public int? Funcionario_id { get; set; }
        public INFRATOR Infrator { get; set; }
        public INFRACAO Infracao { get; set; }
        public string Descricao { get; set; }
        public string? Arquivo { get; set; }
        public string? FeedBack { get; set; }
        public bool Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Protocolo { get; set; }
        public Funcionario? Funcionario { get; set; }
        public Predio Predio { get; set; }

    }
}
