using SOSBackClean.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Interfaces
{
    public interface IFormsManegementService
    {
        Task<FormularioDetailsDTO> ResolveForm(ResolveFormularioDTO dto);
    }
}
