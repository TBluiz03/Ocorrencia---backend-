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
        public int Id { get; set; }
        public string _nome { get; set; }
        public int _nAndar {  get; set; }
        
        public ICollection<Formulario> formularios = new List<Formulario>();

        public Predio(int andar, string nome)
        {
            //Falta colocar as validações (Luiz).

            _nome = nome;
            _nAndar = andar;
   
        }
    }
}
