using AutoMapper;
using Microsoft.Extensions.Logging;
using SOSBackClean.Application.DTOs.Formulario;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Mappings;
using SOSBackClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Services.FormularioServices
{
    public class FormularioQueryService : IFormsQueryService
    {
        private readonly FormularioRepo _formularioRepo;

        private readonly IMapper _mapper;

        public FormularioQueryService(
            FormularioRepo formularioRepository,
            IMapper mapper
            )
        {
            _formularioRepo = formularioRepository;

            _mapper = mapper;
        }
        public async Task<IEnumerable<FormularioListItemDTO>> GetFormsItems()
        {
            var formList = await _formularioRepo.GetFormularios();

            return _mapper.Map<IEnumerable<FormularioListItemDTO>>(formList);
        }

        public async Task<FormularioDetailsDTO> GetFormDetails(string protocolo)
        {
            var form = await _formularioRepo.GetFormularioByProtocol(protocolo);

            return _mapper.Map<FormularioDetailsDTO>(form);
        }
    }
}
