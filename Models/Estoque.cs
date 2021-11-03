using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public int Qnt { get; set; }
    }
}