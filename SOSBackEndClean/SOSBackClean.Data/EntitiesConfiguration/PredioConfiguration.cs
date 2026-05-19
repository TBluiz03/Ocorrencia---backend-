using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SOSBackClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBackClean.Data.EntitiesConfiguration
{
    public class PredioConfiguration : IEntityTypeConfiguration<Predio>
    {
        public void Configure(EntityTypeBuilder<Predio> builder)
        {
            // TABLE
            builder.ToTable("Predio");

            // PRIMARY KEY
            builder.HasKey(x => x.Id);

            // NOME
            builder.Property(x => x._nome)
                .HasColumnName("Nome")
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            // ANDARES
            builder.Property(x => x._nAndar)
                .HasColumnName("Numero de Andares")
                .IsRequired();
        }
    }
}
