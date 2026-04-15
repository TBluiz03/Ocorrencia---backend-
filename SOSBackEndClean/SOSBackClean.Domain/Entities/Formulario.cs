using SOSBackClean.Domain.Validation;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Entities
{
    public class Formulario
    {
        public string Id { get; private set; }
        public string? Nome { get; private set; }
        public Predios Predios { get; private set; }
        public Funcionario? Funcionario { get; private set; }
        public INFRACAO Infracao { get; private set; }
        public string Descricao { get; private set; }
        public string Arquivo { get; private set; }


        public Formulario(string? nome, Predios predios, Funcionario? funcionario, INFRACAO infracao, string descricao, string? arquivo)
        {
            Validation(nome, predios, funcionario, infracao, descricao, arquivo);
            
        }

        public Formulario(string? nome, Predios predios, Funcionario? funcionario, INFRACAO infracao, string descricao, string? arquivo, string id) {  
            Validation(nome, predios, funcionario, infracao, descricao, arquivo);
            Id = id;
            
        }

        public void Validation(string? nome, Predios predios, Funcionario? funcionario, INFRACAO infracao, string descricao, string? arquivo)
        {
            
            DomainValidation.When(nome != null && nome.Length < 3, "O nome do usuário não pode ter menos de 3 letras. ");
            
            Nome = nome;
            Predios = predios;
            Funcionario = funcionario;
            Infracao = infracao;
            Descricao = descricao;
            Arquivo = arquivo;
            
        }
        public static string GerarId(List<string> IdExistente)
        {
            string random = new Random().Next(100).ToString();


            if (IdExistente.Contains(random))
            {
                return GerarId(IdExistente);
            }

            return random.ToString();
        }




    }
}
