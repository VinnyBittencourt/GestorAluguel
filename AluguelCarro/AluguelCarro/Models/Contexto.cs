using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AluguelCarro.Models
{
    public class Contexto : IdentityDbContext<Usuario, NiveisAcesso, string>
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<NiveisAcesso> NiveisAcesso { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
    }
}
