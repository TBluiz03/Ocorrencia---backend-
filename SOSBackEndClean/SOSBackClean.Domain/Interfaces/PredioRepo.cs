using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Interfaces
{
    public interface PredioRepo
    {

        Task<Predio> AtualizarPredio(Predio fun);

        Task<Predio> GetPredioById(int id);

        Task<IEnumerable<Predio>> GetPredios();

    }

}
