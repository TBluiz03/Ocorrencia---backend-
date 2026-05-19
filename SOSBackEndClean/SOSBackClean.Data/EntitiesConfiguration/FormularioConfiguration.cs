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
    public class FormularioConfiguration : IEntityTypeConfiguration<Formulario>
    {
        public void Configure(EntityTypeBuilder<Formulario> builder)
        {
            // TABLE
            builder.ToTable("Formulario");

            // PRIMARY KEY
            builder.HasKey(x => x.Id);

            // ID
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            // PROTOCOLO
            builder.Property(x => x._protocolo)
                .HasColumnName("Protocolo")
                .HasColumnType("varchar(40)")
                .IsRequired();

            // OFENDIDO
            builder.Property(x => x._nomeOfendido)
                .HasColumnName("Ofendido")
                .HasColumnType("nvarchar(70)")
                .IsRequired();

            // PREDIO_ID (FK)
            builder.Property(x => x.Predio_id)
                .HasColumnName("Predio_id")
                .IsRequired();

            // FUNCIONARIO_ID (FK)
            builder.Property(x => x.Funcionario_id)
                .HasColumnName("Funcionario_id")
                .IsRequired();

            // INFRATOR (ENUM -> INT)
            builder.Property(x => x._infrator)
                .HasColumnName("Infrator")
                .HasConversion<int>()
                .IsRequired();

            // INFRACAO (ENUM -> INT)
            builder.Property(x => x._tipoInfracao)
                .HasColumnName("Infracao")
                .HasConversion<int>()
                .IsRequired();

            // DESCRICAO
            builder.Property(x => x._descricao)
                .HasColumnName("Descricao")
                .HasColumnType("nvarchar(300)")
                .IsRequired();

            // ARQUIVO
            builder.Property(x => x._arquivo)
                .HasColumnName("Arquivo")
                .HasColumnType("nvarchar(300)");

            // SALA
            builder.Property(x => x._sala)
                .HasColumnName("Sala")
                .HasColumnType("nvarchar(15)");

            // FEEDBACK
            builder.Property(x => x._feedBack)
                .HasColumnName("FeedBack")
                .HasColumnType("nvarchar(300)")
                .HasDefaultValue(null);

            // DATA
            builder.Property(x => x._dataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();

            // STATUS RESOLUCAO
            builder.Property(x => x._statusResolucao)
                .HasColumnName("StatusResolucao")
                .HasDefaultValue(false);

            // RELACIONAMENTO -> PREDIO
            builder.HasOne(x => x.Predio)
                .WithMany()
                .HasForeignKey(x => x.Predio_id)
                .OnDelete(DeleteBehavior.Restrict);

            // RELACIONAMENTO -> FUNCIONARIO
            builder.HasOne(x => x.Funcionario)
                .WithMany()
                .HasForeignKey(x => x.Funcionario_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
    
}
