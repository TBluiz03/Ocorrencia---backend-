using AutoMapper;
using SOSBackClean.Application.Common;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Services.CatalogServices;
using SOSBackClean.Application.Services.FormularioServices;
using SOSBackClean.Data.Repositories;
using SOSBackClean.Domain.Interfaces;

namespace SOSBackClean.API
{
    public static class EntryPoint
    {

        public static ServiceProvider Provider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ICatalogService, CatalogService>();

            services.AddSingleton<FuncionarioRepo, FuncionarioRepository>();

            services.AddSingleton<PredioRepo, PredioRepository>();

            services.AddSingleton<FormularioRepo, FormularioRepository>();

            services.AddSingleton<IProtocolGenerator, ProtocolGenerator>();

            services.AddSingleton<IFormsCreationService, FormularioCreationService>();

            services.AddSingleton<IFormsQueryService, FormularioQueryService>();

            services.AddSingleton<IFormsManegementService, FormularioManagementService>();


            var provider = services.BuildServiceProvider();

            return provider;
        }


    }
}
