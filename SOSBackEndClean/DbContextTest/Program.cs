using Microsoft.EntityFrameworkCore;
using SOSBackClean.Application.Services;
using SOSBackClean.Data.Context;
using SOSBackClean.Data.Repositories;
using SOSBackClean.Domain;
using SOSBackClean.Domain.Entities;
using System.Runtime.CompilerServices;

class TestClass
{
    static void Main(string[] args)
    {


        using var context = new ApiDbContext();

        context.Database.EnsureCreated();

      

        var fun = context.Funcionario.Where(f => f.Id == 1).ToList();
        context.Remove<Funcionario>(fun[0]);
        context.SaveChanges();

     

    }
}