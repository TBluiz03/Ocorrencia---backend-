using SOSBackClean.Application.DTOs.Funcionario;
using SOSBackClean.Application.DTOs.Predio;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs.Formulario
{
    public record FormularioDetailsDTO
    {
        [JsonPropertyName("NomeOfendido")]
        public string? _nomeOfendido { get; set; }

        [JsonPropertyName("Sala")]
        public string? _sala { get; set; }

        [JsonPropertyName("AndarOcorrencia")]
        public int _andarOcorrencia { get; set; }

        [JsonPropertyName("Id_Infrator")]
        public INFRATOR _infrator { get; set; }

        [JsonPropertyName("Infrator")]
        public string _descricaoInfrator { get; set; }

        [JsonPropertyName("Id_Infracao")]
        public INFRACAO _tipoInfracao { get; set; }

        [JsonPropertyName("Infracao")]
        public string _descricaoInfracao { get; set; }

        [JsonPropertyName("Descricao")]
        public string _descricao { get; set; }

        [JsonPropertyName("Arquivo")]
        public string? _arquivo { get; set; }

        [JsonPropertyName("FeedBack")]
        public string? _feedBack { get; set; }

        [JsonPropertyName("Status")]
        public bool _statusResolucao { get; set; }

        [JsonPropertyName("DataCriacao")]
        public DateTime _dataCriacao { get; set; }

        [JsonPropertyName("Protocolo")]
        public string _protocolo { get; set; }
        public FuncionarioDTO? Funcionario { get; set; }
        public PredioDTO Predio { get; set; }



    }
}
