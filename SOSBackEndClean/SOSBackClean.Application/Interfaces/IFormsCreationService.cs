using SOSBackClean.Application.DTOs.Formulario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Interfaces
{
    public interface IFormsCreationService
    {
        Task<CreateFormularioDataDTO> GetDataToForms();
        Task CreateFormulario(CreateFormularioDTO Dto);
    }
}
