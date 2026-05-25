using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record FuncionarioDTO
    {
        public int Id { get; set; }

        [JsonPropertyName("Nome")]
        public string _nome { get; set; }

        [JsonPropertyName("Foto")]
        public string? _foto { get; set; }

        [JsonPropertyName("Id_Cargo")]
        public CARGO _cargo { get; set; }

        [JsonPropertyName("Cargo")]
        public string _descricaoCargo { get; set; }
    }
}
