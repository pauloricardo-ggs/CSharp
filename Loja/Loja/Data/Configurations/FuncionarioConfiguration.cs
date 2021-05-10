﻿using Loja.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Data.Configurations
{
    class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionários");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.CPF).HasColumnType("VARCHAR(11)").IsRequired();
            builder.Property(p => p.DataNascimento);
            builder.Property(p => p.Telefone).HasColumnType("VARCHAR(11)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)");
            builder.Property(p => p.Salario);
            builder.Property(p => p.Categoria).HasConversion<string>();
            builder.Property(p => p.CEP).HasColumnType("VARCHAR(8)").IsRequired();
            builder.Property(p => p.Numero).IsRequired();
            builder.Property(p => p.Cidade).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Estado).HasColumnType("VARCHAR(2)").IsRequired();
        }
    }
}
