using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record CreateFormularioDTO
    {
        //DTO que vai carregar o JSON vindo do front-end e será convertido em DTO

        [MaxLength(70)]
        public string? _nomeOfendido { get; set; }

        [Required(ErrorMessage = "Prédio é necessário para o formulário")]
        public int Predio_id { get; set; }

        [MaxLength(15)]
        public string? _sala { get; set;  }
        public int _andarOcorrencia { get; set; }
        public int? Funcionario_id { get; set; }

        [Required(ErrorMessage = "O infrator é necessário para a ocorrência")]
        public INFRATOR _infrator { get; set; } 

        [Required(ErrorMessage = "O tipo da infração é obrigatório")]
        public INFRACAO _tipoInfracao { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatória")]
        [MinLength(10)]
        [MaxLength(300)]
        public string _descricao { get; set; }

        [MaxLength(300)]
        public string? _arquivo { get; set; }

    }
}
