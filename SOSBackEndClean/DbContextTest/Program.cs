using SOSBackClean.Data.Context;
using SOSBackClean.Domain;
using System.Runtime.CompilerServices;

class TestClass
{
    static void Main(string[] args)
    {

        var context = new ApiDbContext();

        context.Database.EnsureCreated();
    }
}