using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs.Catalogs
{
    public record InfracaoDTO
    {
        public int _infracao { get; set; }
        public string _descricaoInfracao { get; set; }
    }
}
