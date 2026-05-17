using SOSBackClean.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Entities
{
    public class Predio
    {

        public int _nAndar {  get; set; }
        public int Id { get; set; }

        public ICollection<Formulario> formularios = new List<Formulario>();

        public Predio(int andar, int predio, string? sala)
        {
            _nAndar = andar;
            Id = predio;
        }
    }
}
