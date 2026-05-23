using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record PredioDTO
    {
        public int Id { get; set; }
        public string _nome { get; set; }
        public int _nAndar { get; set; }

    }
}
