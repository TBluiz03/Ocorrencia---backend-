using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs.Catalogs
{
    public record CargoDTO
    {
        public int _cargo { get; set; }
        public string _cargoDescricao { get; set; }
    }
}
