using SOSBackClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Interfaces
{
    public interface FormularioRepo
    {
        Task<Formulario> GetFormularioById(string Id);

        Task<IEnumerable<Formulario>> GetFormularios();

        Task<Formulario> Remove(string Id);

        Task<Formulario> Create(Formulario formulario);
        
        Task<Formulario> Update(string Id, Formulario formulario);
    }
}
