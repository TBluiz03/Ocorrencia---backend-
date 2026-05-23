using Microsoft.EntityFrameworkCore;
using SOSBackClean.Application.Services;
using SOSBackClean.Data.Context;
using SOSBackClean.Data.Repositories;
using SOSBackClean.Domain;
using SOSBackClean.Domain.Entities;
using System.Net;
using System.Runtime.CompilerServices;

class TestClass
{
    static void Main(string[] args)
    {


        var repo = new FormularioRepository();

        var form = repo.GetFormularioByProtocol("F804344").Result;
        var form2 = repo.GetFormularioById(1).Result;

        Console.WriteLine("  Agora por Id: " + form2.Funcionario_id);
     

    }
}