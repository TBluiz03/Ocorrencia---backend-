using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.DTOs
{
    public record FuncionarioDTO
    {
        public int Id { get; set; }
        public string _nome { get; set; }
        public string? _foto { get; set; }
        public int _cargo { get; set; }
    }
}
