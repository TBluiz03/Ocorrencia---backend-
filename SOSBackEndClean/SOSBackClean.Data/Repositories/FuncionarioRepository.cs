using Microsoft.EntityFrameworkCore;
using SOSBackClean.Data.Context;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Data.Repositories
{
    public class FuncionarioRepository : FuncionarioRepo
    {
        private readonly ApiDbContext _funcionarioContext;
        public FuncionarioRepository()
        {
            _funcionarioContext = new ApiDbContext(); //Provisório, apenas para testes, depois unificar em um Bootstrap
        }

        
        public async Task<Funcionario> AtualizarFuncionario(Funcionario funcionarioExistente)
        {
            _funcionarioContext.Funcionarios.Update(funcionarioExistente);
            await _funcionarioContext.SaveChangesAsync();
            return funcionarioExistente;
        }

        public async Task<Funcionario> GetFuncionarioById(int id)
        {
            return await _funcionarioContext.Funcionarios.FindAsync(id);
        }

        public async Task<IEnumerable<Funcionario>> GetFuncionarios()
        {
            return await _funcionarioContext.Funcionarios.ToListAsync();
        }

        public async Task<IEnumerable<Funcionario>> GetFuncionariosByCategory(CARGO cargo)
        {
            return await _funcionarioContext.Funcionarios
                .Where(f => f.Cargo == cargo)
                .ToListAsync();
        }
    }
}
