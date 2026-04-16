using SOSBackClean.Data.Context;
using SOSBackClean.Data.Repositories;
using SOSBackClean.Domain;
using SOSBackClean.Domain.Entities;
using System.Runtime.CompilerServices;

class TestClass
{
    static void Main(string[] args)
    {

        var context = new ApiDbContext();

        context.Database.EnsureCreated();

    }
}