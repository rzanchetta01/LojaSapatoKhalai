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
        public int idModelo { get; set; }
        public int idCliente { get; set; }
        public int Quantidade { get; set; }
        public string DtVenda { get; set; }
    }
}