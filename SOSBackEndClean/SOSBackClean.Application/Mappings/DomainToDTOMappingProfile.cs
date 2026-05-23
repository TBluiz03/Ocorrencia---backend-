using AutoMapper;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<CreateFormularioDTO, Formulario>()
                .ConstructUsing(dto =>
                     new Formulario(
                         dto._nomeOfendido,
                         dto.Predio_id,
                         dto._sala,
                         dto._andarOcorrencia,
                         dto.Funcionario_id ?? 0,
                         dto._infrator,
                         dto._tipoInfracao,
                         dto._descricao,
                         dto._arquivo
                     ));

            CreateMap<Formulario, FormularioDetailsDTO>();
            CreateMap<Formulario, FormularioListItemDTO>();
            CreateMap<Funcionario, FuncionarioDTO>();
            CreateMap<Predio, PredioDTO>();
        }
    }
}
