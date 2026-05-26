using Microsoft.EntityFrameworkCore;
using SOSBackClean.Data.Context;
using SOSBackClean.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("MinhaPoliticaCors", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (true)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope =
      app.Services.CreateScope())
{
    var context =
        scope.ServiceProvider
             .GetRequiredService<ApiDbContext>();

    context.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseCors("MinhaPoliticaCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
