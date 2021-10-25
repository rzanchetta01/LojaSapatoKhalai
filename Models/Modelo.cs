using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lojaSapato.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Fornecedor")]
        public Fornecedor IdFornecedor { get; set; }
        public string CodigoRef { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }

    }
}