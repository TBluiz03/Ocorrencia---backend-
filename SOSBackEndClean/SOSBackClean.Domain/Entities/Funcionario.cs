using SOSBackClean.Domain.Validation;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Entities
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string _nome { get; private set; }
        public string? _foto { get; private set; }
        public CARGO _cargo { get; private set; }

        public ICollection<Formulario> Formularios =  new List<Formulario>();


        //------------------------------------------------------------------------
        public Funcionario(string nome, string? foto, CARGO cargo)
        {
            Validation(nome, foto, cargo);
        }
        public void Validation(string nome, string? foto, CARGO cargo)
        {
            DomainValidation.When(string.IsNullOrEmpty(nome), "O nome do funcionário é obrigatório.");
            DomainValidation.When(nome.Length < 3, "O nome do funcionário não pode ter menos de 3 letras. ");
            _nome = nome;
            _foto = foto;
            _cargo = cargo;
        }

        public string AtualizarNome(string NovoNome)
        {
            if(NovoNome == _nome)
            {
                return "O novo nome não pode ser igual o anterior.";
            }
            else
            {
                DomainValidation.When(string.IsNullOrEmpty(NovoNome), "O nome do funcionário é obrigatório.");
                DomainValidation.When(NovoNome.Length < 3, "O nome do funcionário não pode ter menos de 3 letras. ");

                _nome = NovoNome;

                return "O nome foi atualizado com sucesso.";
            }

        }
        public string AtualizarCargo(CARGO NovoCargo)
        {
            if(NovoCargo == _cargo)
            {
                return "O novo cargo não pode ser igual o anterior.";
            }
            else
            {
                _cargo = NovoCargo;
                return "O cargo foi atualizado com sucesso.";
            }
        }
        public string AtualizarFoto(string? NovaFoto)
        {
            if(NovaFoto == _foto)
            {
                return "A nova foto não pode ser igual a anterior.";
            }
            else
            {
                _foto = NovaFoto;
                return "A foto foi atualizada com sucesso.";
            }
        }
    }

}
