using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaSapatoKhalai.Models;

namespace LojaSapatoKhalai.Data
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
            EstoqueCreation(modelBuilder);
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

            modelBuilder.Entity<Fornecedor>()
                        .HasData(
                            new Fornecedor(1,"China in Shoes", "1953049285142", "China, shin shon shun"),
                            new Fornecedor(2,"Africa has Shoes", "1276629478241", "Africa do Sul, Cidade do Cabo"),
                            new Fornecedor(3,"India doens't do Shoes", "9994724861245", "India, Nova Dehli")
                        );
        }

        private void ModeloCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modelo>()
                        .Property(p => p.CodigoRef)
                        .HasMaxLength(50);

            modelBuilder.Entity<Modelo>()
                        .Property(p => p.Cor)
                        .HasMaxLength(50);

            modelBuilder.Entity<Modelo>()
                        .Property(p => p.Nome)
                        .HasMaxLength(300);

            modelBuilder.Entity<Modelo>()
                        .HasData(
                        new Modelo(1, 1, 1, "asnaeb", "Branco", 36, "Supreme Ben 10 mil", 1500),
                        new Modelo(2, 2, 2, "asnaeba", "Preto", 42, "Chute certo", 350),
                        new Modelo(3, 3, 3, "asnaebbbe", "Cinza", 39, "Skatenis", 150)
                        );
        }

        private void CategoriaCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                        .Property(p => p.Nome)
                        .HasMaxLength(100);

            modelBuilder.Entity<Categoria>()
                        .HasData(
                        new Categoria(1, "Sapato de luxo"),
                        new Categoria(2, "Chuteiras"),
                        new Categoria(3, "Sapatos casuais")
                );
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

            modelBuilder.Entity<Cliente>()
                .HasData(
                    new Cliente(1, "Rodrigo", "1354532", "Mansão maromba", "m"),
                    new Cliente(2, "Marcos", "765432123", "Casa do bom filho", "m"),
                    new Cliente(3, "Ana", "1354532", "Rua Perdida das cruzes", "f")
                );
        }

        private void VendasCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venda>()
                        .Property(p => p.DtVenda)
                        .HasMaxLength(10);

            modelBuilder.Entity<Venda>()
                        .HasData(
                        new Venda(1, 1, 1, 10, "22/06/2021"),
                        new Venda(2, 2, 2, 1, "19/10/2021"),
                        new Venda(3, 3, 3, 1, "03/11/2021")
                );
        }

        private void EstoqueCreation(ModelBuilder model)
        {
            model.Entity<Estoque>()
                .HasData(
                new Estoque(1, 1, 1000),
                new Estoque(2, 2, 10),
                new Estoque(3, 3, 110)
                );
        }
    }
}