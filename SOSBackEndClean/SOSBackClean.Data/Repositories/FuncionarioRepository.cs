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
        public FuncionarioRepository(ApiDbContext funcionarioContext)
        {
            _funcionarioContext = funcionarioContext;
        }

        
        public async Task<Funcionario> AtualizarFuncionario(Funcionario funcionarioExistente)
        {
            _funcionarioContext.Funcionario.Update(funcionarioExistente);
            await _funcionarioContext.SaveChangesAsync();
            return funcionarioExistente;
        }

        public async Task<Funcionario> GetFuncionarioById(int id)
        {
            return await _funcionarioContext.Funcionario.FindAsync(id);
        }

        public async Task<IEnumerable<Funcionario>> GetFuncionarios()
        {
            return await _funcionarioContext.Funcionario.ToListAsync();
        }

        public async Task<IEnumerable<Funcionario>> GetFuncionariosByCategory(CARGO cargo)
        {
            return await _funcionarioContext.Funcionario
                .Where(f => f._cargo == cargo)
                .ToListAsync();
        }
    }
}
