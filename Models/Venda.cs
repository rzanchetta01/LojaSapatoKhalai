using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lojaSapato.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Modelo")]
        public Modelo idModelo { get; set; }

        [ForeignKey("Cliente")]
        public Cliente idCliente { get; set; }
        public int Quantidade { get; set; }
        public string DtVenda { get; set; }
    }
}