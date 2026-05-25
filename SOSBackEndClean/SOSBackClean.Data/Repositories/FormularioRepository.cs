using Microsoft.EntityFrameworkCore;
using SOSBackClean.Data.Context;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Data.Repositories
{
    public class FormularioRepository : FormularioRepo
    {
        private readonly ApiDbContext _formularioContext;
        public FormularioRepository()
        {
            _formularioContext = new ApiDbContext();
        }
        public async Task<Formulario> Create(Formulario formulario)
        {
            _formularioContext.Formulario.Add(formulario);
            await _formularioContext.SaveChangesAsync();
            return formulario;
        }

        public async Task<bool> ExistsProtocol(string protocol)
        {
            return await _formularioContext.Formulario.AnyAsync(f => f._protocolo == protocol);
        }


        public async Task<Formulario> GetFormularioById(int id)
        {
            return await _formularioContext.Formulario
                .Include(f => f.Predio)
                .Include(f => f.Funcionario)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Formulario> GetFormularioByProtocol(string protocolo)
        {
            return await _formularioContext.Formulario
                .Include(f => f.Predio)
                .Include(f => f.Funcionario)
                .FirstOrDefaultAsync(f => f._protocolo == protocolo);
        }

        public async Task<IEnumerable<Formulario>> GetFormularios()
        {
            return await _formularioContext.Formulario.ToListAsync();
        }

        public async Task<Formulario> Remove(int id)
        {
            var formularioToRemove = GetFormularioById(id);
            _formularioContext.Formulario.Remove(formularioToRemove.Result);
            await _formularioContext.SaveChangesAsync();
            return formularioToRemove.Result;

        }

        public async Task<Formulario> Update(Formulario formulario)
        {
            _formularioContext.Formulario.Update(formulario);
            await _formularioContext.SaveChangesAsync();
            return formulario;
        }

       
    }
}
