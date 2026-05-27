using AutoMapper;
using SOSBackClean.Application.DTOs.Formulario;
using SOSBackClean.Application.DTOs.Funcionario;
using SOSBackClean.Application.DTOs.Predio;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.ValueObjects;
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
                         dto.Funcionario_id,
                         dto._infrator,
                         dto._tipoInfracao,
                         dto._descricao,
                         dto._arquivo
                     ));

            CreateMap<Formulario, FormularioDetailsDTO>().ForMember(
                dest => dest._descricaoInfracao,
                opt => opt.MapFrom(src => src._tipoInfracao.ToString())
                ).ForMember(dest => dest._descricaoInfrator,
                opt => opt.MapFrom(src => src._infrator.ToString())
                );

            CreateMap<Formulario, FormularioListItemDTO>().ForMember(
                dest => dest._descricaoInfracao,
                opt => opt.MapFrom(src => src._tipoInfracao.ToString())
                );

            CreateMap<Funcionario, FuncionarioDTO>().ForMember(
                dest => dest._descricaoCargo,
                opt => opt.MapFrom(src => src._cargo.ToString())
                );

            CreateMap<Predio, PredioDTO>();

        }
    }
}
