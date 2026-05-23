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
        public string? _nomeOfendido { get; set; }
        public string? _sala { get; set; }
        public int _andarOcorrencia { get; set; }
        public INFRATOR _infrator { get; set; }
        public INFRACAO _tipoInfracao { get; set; }
        public string _descricao { get; set; }
        public string? _arquivo { get; set; }
        public string? _feedBack { get; set; }
        public bool _statusResolucao { get; set; }
        public DateTime _dataCriacao { get; set; }
        public string _protocolo { get; set; }
        public FuncionarioDTO? Funcionario { get; set; }
        public PredioDTO Predio { get; set; }

    }
}
