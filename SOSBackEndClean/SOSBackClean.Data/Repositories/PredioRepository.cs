using Microsoft.EntityFrameworkCore;
using SOSBackClean.Data.Context;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Data.Repositories
{
    public class PredioRepository : PredioRepo
    {
        private readonly ApiDbContext _predioContext;

        public PredioRepository(ApiDbContext predioContext)
        {
             _predioContext = predioContext;
        }
        public async Task<Predio> AtualizarPredio(Predio predio)
        {
            _predioContext.Update(predio);
            await _predioContext.SaveChangesAsync();
            return predio;
        }

        public async Task<Predio> GetPredioById(int id)
        {
            return await _predioContext.Predio.FindAsync(id);
        }

        public async Task<IEnumerable<Predio>> GetPredios()
        {
            return await _predioContext.Predio.ToListAsync();
        }
    }
}
