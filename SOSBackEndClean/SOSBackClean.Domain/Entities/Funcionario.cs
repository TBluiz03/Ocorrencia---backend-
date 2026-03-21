using SOSBackClean.Domain.Validation;
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
        public string Nome;
        public string? Foto;
        public CARGO Cargo;

        public Funcionario(string nome, string? foto, CARGO cargo)
        {
            Validation(nome, foto, cargo);
        }
        public void Validation(string nome, string? foto, CARGO cargo)
        {
            DomainValidation.When(string.IsNullOrEmpty(Nome), "O nome do funcionário é obrigatório.");
            DomainValidation.When(Nome.Length < 3, "O nome do funcionário não pode ter menos de 3 letras. ");

            Nome = nome;
            Foto = foto;
            Cargo = cargo;
        }

        public string AtualizarNome(string NovoNome)
        {
            if(NovoNome == Nome)
            {
                return "O novo nome não pode ser igual o anterior.";
            }
            else
            {
                DomainValidation.When(string.IsNullOrEmpty(NovoNome), "O nome do funcionário é obrigatório.");
                DomainValidation.When(NovoNome.Length < 3, "O nome do funcionário não pode ter menos de 3 letras. ");

                Nome = NovoNome;

                return "O nome foi atualizado com sucesso.";
            }

        }
        public string AtualizarCargo(CARGO NovoCargo)
        {
            if(NovoCargo == Cargo)
            {
                return "O novo cargo não pode ser igual o anterior.";
            }
            else
            {
                Cargo = NovoCargo;
                return "O cargo foi atualizado com sucesso.";
            }
        }
        public string AtualizarFoto(string? NovaFoto)
        {
            if(NovaFoto == Foto)
            {
                return "A nova foto não pode ser igual a anterior.";
            }
            else
            {
                Foto = NovaFoto;
                return "A foto foi atualizada com sucesso.";
            }
        }
    }


    public enum CARGO {
        MEDICO, 
        ENFERMEIRO,
        SECRETARIO,
        TECNICO,
        MANUTENCAO 
    }
}
