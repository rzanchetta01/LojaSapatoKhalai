using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public int idModelo { get; set; }
        public int idCliente { get; set; }
        public int Quantidade { get; set; }
        public string DtVenda { get; set; }

        public Venda(int id, int idModelo, int idCliente, int quantidade, string dtVenda)
        {
            Id = id;
            this.idModelo = idModelo;
            this.idCliente = idCliente;
            Quantidade = quantidade;
            DtVenda = dtVenda;
        }
    }
}