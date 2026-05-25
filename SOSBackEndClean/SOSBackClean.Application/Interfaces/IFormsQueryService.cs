using SOSBackClean.Application.DTOs.Formulario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Interfaces
{
    public interface IFormsQueryService
    {
        Task<IEnumerable<FormularioListItemDTO>> GetFormsItems();
        Task<FormularioDetailsDTO> GetFormDetails(string protocolo);
    }
}
