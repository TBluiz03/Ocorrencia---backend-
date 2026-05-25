using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs.Predio
{
    public record PredioDTO
    {
        public int Id { get; set; }

        [JsonPropertyName("Nome")]
        public string _nome { get; set; }

        [JsonPropertyName("Numero_de_andares")]
        public int _nAndar { get; set; }

    }
}
