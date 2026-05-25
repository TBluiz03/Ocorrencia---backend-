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
    public class FormularioManagementService : IFormsManegementService
    {
        private readonly FormularioRepo _formularioRepo;

        private readonly IMapper _mapper;

        public FormularioManagementService(
            FormularioRepo formularioRepository,
            IMapper mapper
            )
        {
            _formularioRepo = formularioRepository;


            _mapper = mapper;
        }

        public async Task<FormularioDetailsDTO> ResolveForm(ResolveFormularioDTO dto)
        {
            var form = await _formularioRepo.GetFormularioById(dto.Id);

            if(form == null)
            {
                throw new Exception("Não achei o formulario");
            }

            form.ResolverOcorrencia(dto.Feedback);

            return _mapper.Map<FormularioDetailsDTO>(await _formularioRepo.Update(form));
        }
    }
}
