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
        public INFRATOR _infrator { get; private set; }        
        public INFRACAO _tipoInfracao { get; private set; }
        public string _descricao { get; private set; }
        public string? _arquivo { get; private set; }
        public string? _feedBack { get; private set; } = null;
        public DateTime _dataCriacao {  get; private set; }
        
        
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
            int predio_id, int funcionario_id) // ???? 
        {
            Validation(protocolo, nomeOfendido, sala, andarOcorrencia, infracao, descricao, arquivo);

            _dataCriacao = DateTime.Now;
        }


        public void Validation(string protocolo, string? nomeOfendido, string? sala, int andarOcorrencia, INFRACAO infracao, string descricao, string? arquivo)
        {
            //Criar validações
            //Criar validação para verificar se o protocolo é único (Luiz).

            DomainValidation.When(string.IsNullOrEmpty(protocolo), "O protocolo é obrigatório.");
            DomainValidation.When(protocolo.Length != 10, "O protocolo precisa ter 10 caracteres.");
            DomainValidation.When(int.IsNullOrEmpty(andarOcorrencia), "O andar da ocorrência é obrigatório.");
            DomainValidation.When(andarOcorrencia < 0, "O andar da ocorrência não pode ter valores negativos.");
            DomainValidation.When(INFRACAO.IsNullorEmpty(infracao), "O tipo de infração é obrigatório.");
            DomainValidation.When(string.IsNullOrEmpty(descricao), "A descrição da ocorrência é obrigatória.");
            
            _protocolo = protocolo;
            _nomeOfendido = nomeOfendido;
            _sala = sala;
            _andarOcorrencia = andarOcorrencia;
            _tipoInfracao = infracao;
            _descricao = descricao;
            _arquivo = arquivo;
            _nomeOfendido = nomeOfendido; 

        }

        //Precisamos de métodos para atualizar feedback 
        public void ResolverOcorrencia(string feedback)
        {
            DomainValidation.When(IsNullorEmpty(feedback), "O feedback é obrigatório.");

            _feedBack = feedback;
            _statusResolucao = true;
        }

        public void ReabrirOcorrencia()
        {
            _statusResolucao = false;
        }

        public void AssociaInfrator(INFRATOR infrator) {

            DomainValidation.When(INFRATOR.IsNullorEmpty(infrator), "O infrator é obrigatório.");

            _infrator = infrator;
        }
        public void AlterarInfrator(INFRATOR novoInfrator)
        {
            _infrator = novoInfrator;
        }
    }
}
