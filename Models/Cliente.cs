using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }

        public Cliente(int id, string nome, string cPF, string endereco, string sexo)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            Sexo = sexo;
        }
    }
}