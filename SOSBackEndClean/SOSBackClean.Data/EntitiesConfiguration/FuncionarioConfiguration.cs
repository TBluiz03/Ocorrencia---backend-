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
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            // TABLE
            builder.ToTable("Funcionario");

            // PRIMARY KEY
            builder.HasKey(x => x.Id);

            // ID
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            // NOME
            builder.Property(x => x._nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(70)")
                .IsRequired();

            // FOTO
            builder.Property(x => x._foto)
                .HasColumnName("Foto")
                .HasColumnType("nvarchar(300)");

            // CARGO
            builder.Property(x => x._cargo)
                .HasColumnName("Cargo")
                .HasConversion<int>() // 'enum' para 'int'
                .IsRequired();
        }
    }
}
