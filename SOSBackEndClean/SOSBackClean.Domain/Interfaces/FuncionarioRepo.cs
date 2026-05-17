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
     
        Task<Funcionario> AtualizarFuncionario(int id);

        Task <Funcionario> GetFuncionarioById(int id);

        Task <IEnumerable <Funcionario>> GetFuncionarios();

        Task<IEnumerable<Funcionario>> GetFuncionariosByCategory(CARGO cargo);

    }


}
