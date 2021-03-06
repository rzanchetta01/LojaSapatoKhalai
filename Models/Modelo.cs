using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }
        public int IdFornecedor { get; set; }
        public int IdCategoria { get; set; }
        public string CodigoRef { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Modelo(int id, int idFornecedor, int idCategoria, string codigoRef, string cor, int tamanho, string nome, double preco)
        {
            Id = id;
            IdFornecedor = idFornecedor;
            IdCategoria = idCategoria;
            CodigoRef = codigoRef;
            Cor = cor;
            Tamanho = tamanho;
            Nome = nome;
            Preco = preco;
        }
    }
}