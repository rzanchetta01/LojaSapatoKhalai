using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lojaSapato.Models
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Modelo")]
        public Modelo IdModelo { get; set; }
        public int Qnt { get; set; }
    }
}