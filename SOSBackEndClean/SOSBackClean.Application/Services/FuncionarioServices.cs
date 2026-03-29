using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Services
{
    public class FuncionarioServices
    {
        public FuncionarioRepo _FuncionarioRepo;
        public FuncionarioServices(FuncionarioRepo funcionarioRepo)
        {
             _FuncionarioRepo = funcionarioRepo;
        }
        public async Task<IEnumerable <Funcionario>> GetFuncionarios()
        {
            return await _FuncionarioRepo.GetFuncionarios();
        }
    }

    
}
