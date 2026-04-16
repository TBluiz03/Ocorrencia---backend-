using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Interfaces
{
    public interface FuncionarioRepo
    {
        //Comandos
       // Task<Funcionario> AtualizarNome(string NovoNome);
        
       // Task<Funcionario> AtualizarCargo(CARGO NovoCargo);
         
       // Task<Funcionario> AtualizarFoto(string? NovaFoto);

        Task<Funcionario> AtualizarFuncionario(Funcionario funcionarioExistente);

        //Consultas

        Task <Funcionario> GetFuncionarioById(int id);

        Task <IEnumerable <Funcionario>> GetFuncionarios();

        Task<IEnumerable<Funcionario>> GetFuncionariosByCategory(CARGO cargo);

    }


}
