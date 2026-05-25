using AutoMapper;
using Microsoft.Extensions.Logging;
using SOSBackClean.Application.DTOs;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Mappings;
using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Services.FormularioServices
{
    public class FormularioCreationService : IFormsCreationService
    {
        private readonly PredioRepo _predioRepo;
        private readonly FuncionarioRepo _funcionarioRepo;
        private readonly FormularioRepo _formularioRepo;

        private readonly IProtocolGenerator _protocolGenerator;
        private readonly ICatalogService _catalogService;
        private readonly IMapper _mapper;

        public FormularioCreationService(
            PredioRepo predioRepository,
            FuncionarioRepo funcionarioRepository,
            FormularioRepo formularioRepository,
            IProtocolGenerator protocolGenerator,
            ICatalogService catalogService
            )
        {
            
            _predioRepo = predioRepository;
            _funcionarioRepo = funcionarioRepository;
            _formularioRepo = formularioRepository;


            _catalogService = catalogService;
            _protocolGenerator = protocolGenerator;


            var loggerFactory = LoggerFactory.Create(builder => { });
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new DomainToDTOMappingProfile()), loggerFactory); var mapper = config.CreateMapper();
            _mapper = config.CreateMapper();
        }

        public async Task<CreateFormularioDataDTO> GetDataToForms()
        {
            var predios = await _predioRepo.GetPredios();
            var funcionarios = await _funcionarioRepo.GetFuncionarios();

            return new CreateFormularioDataDTO
            {
                Predios = _mapper.Map<IEnumerable<PredioDTO>>(predios),
                Funcionarios = _mapper.Map<IEnumerable<FuncionarioDTO>>(funcionarios),

                Catalog = _catalogService.GetValuesCatalogos()
            };
        }

        public async Task CreateFormulario(CreateFormularioDTO Dto)
        {
            var formulario = _mapper.Map<Formulario>(Dto);

            formulario.SetProtocolo(await _protocolGenerator.GenerateProtocolAsync());

            await _formularioRepo.Create(formulario);
        }
    }
}
