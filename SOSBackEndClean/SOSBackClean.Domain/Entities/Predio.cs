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
        public int _nAndar { get; set; }

        public Predio(int nAndar, string nome)
        {
            //Falta colocar as validações (Luiz).
            Validation(nome, nAndar);
        }

        public void Validation(string nome, int nAndar)
        {
            DomainValidation.When(string.IsNullOrEmpty(nome), "O nome do prédio é obrigatório.");
            DomainValidation.When(nome.Length < 3, "O nome do prédio não pode ter menos de 3 letras. ");
            DomainValidation.When(nAndar < 0, "O andar não pode ter andares com valores negativos. ");
            DomainValidation.When(nAndar == 0, "O prédio precisa ter andares.");

            _nome = nome;
            _nAndar = nAndar;
        }
    }
}
