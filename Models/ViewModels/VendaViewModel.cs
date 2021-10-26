using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class VendaViewModel
    {
        public string NomeCliente { get; set; }
        public string NomeModelo { get; set; }
        public string NomeFornecedor { get; set; }
        public string DescicaoModelo { get; set; }
        public int QuantidadeModelo { get; set; }
        public DateTime DataCompra { get; set; }
        public double PrecoCompra { get; set; }
    }
}
