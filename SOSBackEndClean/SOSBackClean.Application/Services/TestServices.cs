using AutoMapper;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Services
{
    public class TestServices
    {
        private readonly FormularioRepo _FormularioRepo;
        private readonly FuncionarioRepo _FuncionarioRepo;
        private readonly PredioRepo _PredioRepo;

        public IMapper mapper;

        public TestServices(FormularioRepo formularioRepo, FuncionarioRepo funcionarioRepo, PredioRepo predioRepo, IMapper map)
        {
            _FormularioRepo = formularioRepo;
            _FuncionarioRepo = funcionarioRepo;
            _PredioRepo = predioRepo;
            mapper = map;
        }

        public async Task<CreateFormularioDataDTO> GetDataToForms()
        {
            var predios = await _PredioRepo.GetPredios();
            var funcionarios = await _FuncionarioRepo.GetFuncionarios();

            return new CreateFormularioDataDTO
            {
                Predios = mapper.Map<IEnumerable<PredioDTO>>(predios),
                Funcionarios = mapper.Map<IEnumerable<FuncionarioDTO>>(funcionarios)
            };
        }

        public async Task CreateFormulario(CreateFormularioDTO Dto)
        {
            var formulario = mapper.Map<Formulario>(Dto);
            formulario.SetProtocolo("#" + RandomNumberGenerator.GetHexString(7));
            await _FormularioRepo.Create(formulario);
        }

        public async Task<IEnumerable<FormularioListItemDTO>> GetFormsItems()
        {
            var formList = await _FormularioRepo.GetFormularios();

            return mapper.Map<IEnumerable<FormularioListItemDTO>>(formList);
        }

        public async Task<FormularioDetailsDTO> GetFormDetails(string protocolo)
        {
            var form = await _FormularioRepo.GetFormularioByProtocol(protocolo);

            return mapper.Map<FormularioDetailsDTO>(form);
        }
    }
}
