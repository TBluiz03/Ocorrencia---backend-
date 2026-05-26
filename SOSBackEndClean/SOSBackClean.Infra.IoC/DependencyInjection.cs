using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SOSBackClean.Application.Common;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Application.Mappings;
using SOSBackClean.Application.Services.CatalogServices;
using SOSBackClean.Application.Services.FormularioServices;
using SOSBackClean.Data.Context;
using SOSBackClean.Data.Repositories;
using SOSBackClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApiDbContext>(options =>
            options.UseMySql(connectionString,
            new MySqlServerVersion(new Version(9,4,0)),
            b => b.MigrationsAssembly(typeof(ApiDbContext).Assembly.FullName)
            ));

            services.AddScoped<FuncionarioRepo, FuncionarioRepository>();
            services.AddScoped<PredioRepo, PredioRepository>();
            services.AddScoped<FormularioRepo, FormularioRepository>();

            services.AddScoped<IProtocolGenerator, ProtocolGenerator>();

            services.AddSingleton<ICatalogService, CatalogService>();
            services.AddScoped<IFormsCreationService, FormularioCreationService>();
            services.AddScoped<IFormsQueryService, FormularioQueryService>();
            services.AddScoped<IFormsManegementService, FormularioManagementService>();

            services.AddAutoMapper(cfg =>
            {},
            typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
