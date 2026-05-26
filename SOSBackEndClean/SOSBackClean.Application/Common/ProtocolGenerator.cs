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

            bool Existe = false;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            do
            {
                Random random = new Random();

                protocol = "#" + new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray()) +
                    new string(Enumerable.Repeat(numbers, 7).Select(s => s[random.Next(s.Length)]).ToArray());

                Existe = await _FormularioRepo.ExistsProtocol(protocol);
            } while (Existe);

            return protocol;

        }
    }
}
