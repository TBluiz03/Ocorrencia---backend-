using SOSBackClean.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.ValueObjects
{
    public class Predios
    {
        const int ANDARES = 5;
        const int N_PREDIOS = 3;

        public int Andar;
        public int Predio;
        public string? Sala;

        public Predios(int andar, int predio, string? sala)
        {
            DomainValidation.When(Andar < 1 || Andar > ANDARES, $"O número do andar deve ser entre 1 e {ANDARES}.");
            DomainValidation.When(Predio < 1 || Predio > N_PREDIOS, $"O número do prédio deve ser entre 1 e {N_PREDIOS}.");

            Andar = andar;
            Predio = predio;
            Sala = sala;
        }
    }
}
