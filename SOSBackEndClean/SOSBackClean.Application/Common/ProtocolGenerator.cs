using SOSBackClean.Domain.Interfaces;
using System.Security.Cryptography;

namespace SOSBackClean.Application.Common
{
    public class ProtocolGenerator  : IProtocolGenerator
    {
        private readonly FormularioRepo _FormularioRepo;

        public ProtocolGenerator(FormularioRepo formularioRepo)
        {

            _FormularioRepo = formularioRepo;   

        }

        public async Task<string> GenerateProtocolAsync()
        {
            string protocol;

            //Parte pro luiz fazer
            protocol = "Quem é esse neguin?? ";


            return protocol;

        }
    }
}
