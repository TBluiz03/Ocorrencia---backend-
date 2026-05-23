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
        public int Id { get; set; }
        public bool _statusResolucao { get; set; } = false;
        public string _protocolo { get; set; }
        public string? _nomeOfendido { get; set; } 
        public string? _sala { get; set; }
        public int _andarOcorrencia { get; set; }
        public INFRATOR _infrator { get; set; }        
        public INFRACAO _tipoInfracao { get; set; }
        public string _descricao { get; set; }
        public string? _arquivo { get; set; }
        public string? _feedBack { get; set; } = null;
        public DateTime _dataCriacao {  get; set; }
        
        
        public int Predio_id { get; set; }
        public Predio Predio { get; set; }
        public int Funcionario_id { get; set; }
        public Funcionario? Funcionario { get; set; }

     
        public Formulario(
            string? nomeOfendido,
            int predio_id,
            string? sala,
            int andarOcorrencia,
            int funcionario_id,
            INFRATOR infrator,
            INFRACAO tipoInfracao,
            string descricao,
            string? arquivo
            ) 
        {
            Validation(nomeOfendido,predio_id,sala,andarOcorrencia,funcionario_id,infrator,tipoInfracao,descricao,arquivo);

            _dataCriacao = DateTime.Now;
        }


        public void Validation(string? nomeOfendido,
            int predio_id,
            string? sala,
            int andarOcorrencia,
            int funcionario_id,
            INFRATOR infrator,
            INFRACAO tipoInfracao,
            string descricao,
            string? arquivo)
        {
            //Criar validações
            //Criar validação para verificar se o protocolo é único (Luiz).

            DomainValidation.When(infrator == 0 && funcionario_id == 0, "A ocorrência não bate com os requisitos, funcionario inexistente");
            DomainValidation.When(andarOcorrencia == 0, "O andar da ocorrência é obrigatório.");
            DomainValidation.When(andarOcorrencia < 0, "O andar da ocorrência não pode ter valores negativos.");
            DomainValidation.When(tipoInfracao == 0, "O tipo de infração é obrigatório.");
            DomainValidation.When(string.IsNullOrEmpty(descricao), "A descrição da ocorrência é obrigatória.");
            DomainValidation.When(predio_id == 0, "O ID do prédio é obrigatório.");

            _infrator = infrator;
            _nomeOfendido = nomeOfendido;
            _sala = sala;
            _andarOcorrencia = andarOcorrencia;
            _tipoInfracao = tipoInfracao;
            _descricao = descricao;
            _arquivo = arquivo;
            _nomeOfendido = nomeOfendido; 
            Predio_id = predio_id;
            Funcionario_id = funcionario_id;
        }

        public void SetProtocolo(string protocolo)
        {
            _protocolo = protocolo;
        }

        //Precisamos de métodos para atualizar feedback 
        public void ResolverOcorrencia(string feedback)
        {
            DomainValidation.When(string.IsNullOrEmpty(feedback), "O feedback é obrigatório.");

            _feedBack = feedback;
            _statusResolucao = true;
        }

        public void ReabrirOcorrencia()
        {
            _statusResolucao = false;
        }

        public void AssociaInfrator(INFRATOR infrator) {

            DomainValidation.When(infrator == 0, "O infrator é obrigatório.");

            _infrator = infrator;
        }
        public void AlterarInfrator(INFRATOR novoInfrator)
        {
            _infrator = novoInfrator;
        }
    }
}
