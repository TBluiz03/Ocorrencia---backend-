using SOSBackClean.Application.DTOs;
using SOSBackClean.Application.Interfaces;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Services.CatalogServices
{
    public class CatalogService : ICatalogService
    {
     
        public CatalogDTO GetValuesCatalogos()
        {
            return new CatalogDTO
            {
                Cargos = Enum.GetValues<CARGO>().Select(c =>
                new CargoDTO
                {
                    _cargo = (int)c,
                    _cargoDescricao = c.ToString()
                }),

                Infracoes = Enum.GetValues<INFRACAO>().Select(i =>
                new InfracaoDTO
                {
                    _infracao = (int)i,
                    _descricaoInfracao = i.ToString()
                }),

                Infratores = Enum.GetValues<INFRATOR>().Select(i =>
                new InfratorDTO
                {
                    _infrator = (int)i,
                    _descricaoInfrator = i.ToString()
                })
            };
        }
    }
}
