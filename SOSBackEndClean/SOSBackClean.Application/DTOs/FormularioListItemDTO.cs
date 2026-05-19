using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record FormularioListItemDTO
    {
        public bool Status { get; set; }
        public string Protocolo { get; set; }
        public INFRACAO Infracao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
