using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record CatalogDTO
    {
        public IEnumerable<CargoDTO> Cargos { get; set; }
        public IEnumerable<InfratorDTO> Infratores { get; set; }
        public IEnumerable<InfracaoDTO> Infracoes { get; set; }
    }
}
