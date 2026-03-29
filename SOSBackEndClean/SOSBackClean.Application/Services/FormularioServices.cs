using SOSBackClean.Domain.Entities;
using SOSBackClean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Application.Services
{
    public class FormularioServices
    {
        public FormularioRepo _FormularioRepo;
        public FormularioServices(FormularioRepo formularioRepo)
        {
            _FormularioRepo = formularioRepo;
        }


        //Comandos

        //O formulario que chega via parametro vem sem o id e oformulario que enviamos no método create já tem o id gerado
        public async Task<Formulario> CreateFormulario(Formulario formulario_1)
        {
            var IdExistente = GetFormularios().Result.Select(x => x.Id).ToList(); //Retorna uma lista dos ids existentes

            var Formulario_2 = new Formulario(formulario_1.Nome, formulario_1.Predios, formulario_1.Funcionario, formulario_1.Infracao,
                formulario_1.Descricao, formulario_1.Arquivo, Formulario.GerarId(IdExistente));
            return await _FormularioRepo.Create(Formulario_2);
        }
        public async Task<Formulario> UpdateFormulario(Formulario formulario)
        {
            return await _FormularioRepo.Update(formulario.Id, formulario);
        }
        public async Task<Formulario> RemoveFormulario(string Id)
        {
            return await _FormularioRepo.Remove(Id);
        }
        //Consultas
        //Função usada pelo adm para listar os formulários
        public async Task<IEnumerable<Formulario>> GetFormularios()
        {
            return await _FormularioRepo.GetFormularios();
        }
        //Função usada pelo usuário para visualizar sua ocorrência
        public async Task<Formulario> GetFormularioById(string Id)
        {
            return await _FormularioRepo.GetFormularioById(Id);
        }
    }
}
