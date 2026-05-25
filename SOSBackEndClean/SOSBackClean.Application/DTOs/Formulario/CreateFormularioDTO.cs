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
    public record CreateFormularioDTO
    {
        //DTO que vai carregar o JSON vindo do front-end e será convertido em DTO

        [MaxLength(70)]
        [JsonPropertyName("NomeOfendido")]
        public string? _nomeOfendido { get; set; }

        [Required(ErrorMessage = "Prédio é necessário para o formulário")]
        public int Predio_id { get; set; }

        [MaxLength(15)]
        [JsonPropertyName("Sala")]
        public string? _sala { get; set; }

        [Range(1, 9999)]
        [JsonPropertyName("AndarOcorrencia")]
        public int _andarOcorrencia { get; set; }

        [Range(0, 9999)]
        public int? Funcionario_id { get; set; }

        [Required(ErrorMessage = "O infrator é necessário para a ocorrência")]
        [JsonPropertyName("Id_Infrator")]
        public INFRATOR _infrator { get; set; }

        [Required(ErrorMessage = "O tipo da infração é obrigatório")]
        [JsonPropertyName("Id_Infracao")]
        public INFRACAO _tipoInfracao { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatória")]
        [JsonPropertyName("Descricao")]
        [MinLength(10)]
        [MaxLength(300)]
        public string _descricao { get; set; }

        [MaxLength(300)]
        [JsonPropertyName("Arquivo")]
        public string? _arquivo { get; set; }

    }
}
