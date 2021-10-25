using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lojaSapato.Models;

namespace lojaSapato.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FornecedorCreation(modelBuilder);
            ModeloCreation(modelBuilder);
            CategoriaCreation(modelBuilder);
            ClientesCreation(modelBuilder);
            VendasCreation(modelBuilder);
        }

        private void FornecedorCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                        .Property(p => p.Nome)
                         .HasMaxLength(200);

            modelBuilder.Entity<Fornecedor>()
                        .Property(p => p.CNPJ)
                        .HasMaxLength(14);

            modelBuilder.Entity<Fornecedor>()
                        .Property(p => p.Endereco)
                        .HasMaxLength(200);
        }

        private void ModeloCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modelo>()
                        .Property(p => p.CodigoRef)
                        .HasMaxLength(50);

            modelBuilder.Entity<Modelo>()
                        .Property(p => p.Cor)
                        .HasMaxLength(50);
        }

        private void CategoriaCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                        .Property(p => p.Nome)
                        .HasMaxLength(100);
        }

        private void ClientesCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                        .Property(p => p.Nome)
                        .HasMaxLength(300);

            modelBuilder.Entity<Cliente>()
                        .Property(p => p.CPF)
                        .HasMaxLength(11);

            modelBuilder.Entity<Cliente>()
                        .Property(p => p.Endereco)
                        .HasMaxLength(300);

            modelBuilder.Entity<Cliente>()
                        .Property(p => p.Sexo)
                        .HasMaxLength(1);
        }

        private void VendasCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venda>()
                        .Property(p => p.DtVenda)
                        .HasMaxLength(10);
        }
    }
}