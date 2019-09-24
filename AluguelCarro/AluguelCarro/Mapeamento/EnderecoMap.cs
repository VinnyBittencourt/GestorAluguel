﻿using AluguelCarro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Mapeamento
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(a => a.EnderecoId);

            builder.Property(a => a.Rua).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Bairro).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Cidade).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Estado).IsRequired().HasMaxLength(100);

            builder.HasOne(e => e.Usuario).WithMany(e => e.Enderecos).HasForeignKey(e => e.UsuarioId);

            builder.ToTable("Enderecos");
        }
    }
}
