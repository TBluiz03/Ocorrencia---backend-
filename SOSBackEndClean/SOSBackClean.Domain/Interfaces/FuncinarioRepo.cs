using SOSBackClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Interfaces
{
    public interface FuncinarioRepo
    {
        //Comandos
        Task<Funcionario> AtualizarNome(string NovoNome);
        
        Task<Funcionario> AtualizarCargo(CARGO NovoCargo);
         

        Task<Funcionario> AtualizarFoto(string? NovaFoto);

        //Consultas

        Task <Funcionario> GetFuncionario(string Nome);

        Task <IEnumerable <Funcionario>> GetFuncionarios();

        Task<IEnumerable<Funcionario>> GetFuncionariosByCategory(CARGO Cargo);

    }


}
