using SOSBackClean.Domain.Validation;
using SOSBackClean.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Domain.Entities
{
    public class Formulario
    {
        public int Id { get; private set; }
        public bool _statusResolucao { get; private set; } = false;
        public string _protocolo { get; private set; }
        public string? _nomeOfendido { get; private set; }
        public string? _sala { get; private set; }
        public int _andarOcorrencia { get; private set; }
        public INFRACAO _tipoInfracao { get; private set; }
        public string _descricao { get; private set; }
        public string? _arquivo { get; private set; }
        public string? _feedBack { get; private set; } = null;
        
        public int Predio_id { get; private set; }
        public Predio Predio { get; private set; }

        public int Funcionario_id { get; private set; }
        public Funcionario? Funcionario { get; private set; }

        public Formulario(
            string protocolo,
            string? nomeOfendido,
            string? sala,
            int andarOcorrencia,
            INFRACAO infracao,
            string descricao,
            string? arquivo,
            int predio_id, int funcionario_id)
        {
            Validation();
        }


        public void Validation()
        {
            
           //Criar validações
            
        }

        //Precisamos de métodos para atualizar feedback 
    }
}
