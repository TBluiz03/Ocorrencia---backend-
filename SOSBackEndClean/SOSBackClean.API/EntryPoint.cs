using AutoMapper;
using SOSBackClean.Application.Mappings;
using SOSBackClean.Application.Services;
using SOSBackClean.Data.Repositories;

namespace SOSBackClean.API
{
    public static class EntryPoint
    {
        public static TestServices TesteServices()
        {
            var formRepo = new FormularioRepository();
            var funRepo = new FuncionarioRepository();
            var predioRepo = new PredioRepository();

            var loggerFactory =
            LoggerFactory.Create(builder => { });


            var config = new MapperConfiguration(cfg => cfg.AddProfile(new DomainToDTOMappingProfile()), loggerFactory);

            var mapper = config.CreateMapper();

            return new TestServices(formRepo, funRepo, predioRepo, mapper);
        }

    }
}
