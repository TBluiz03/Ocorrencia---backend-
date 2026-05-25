using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record FormularioListItemDTO
    {
        public int Id { get; set; }

        [JsonPropertyName("Status")]
        public bool _statusResolucao { get; set; }

        [JsonPropertyName("Protocolo")]
        public string _protocolo { get; set; }

        [JsonPropertyName("Id_Infracao")]
        public INFRACAO _tipoInfracao { get; set; }

        [JsonPropertyName("Infracao")]
        public string _descricaoInfracao { get; set; }

        [JsonPropertyName("DataCriacao")]
        public DateTime _dataCriacao { get; set; }
    }
}
