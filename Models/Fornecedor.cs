using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models
{
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }

        public Fornecedor(int id, string nome, string cNPJ, string endereco)
        {
            Id = id;
            Nome = nome;
            CNPJ = cNPJ;
            Endereco = endereco;
        }
    }
}