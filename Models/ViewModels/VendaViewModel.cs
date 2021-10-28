using System.Collections.Generic;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class VendaViewModel
    {

        public List<string> NomeModelo { get; set; }
        public List<string> NomeFornecedor { get; set; }
        public List<int> QuantidadeModelo { get; set; }
        public string NomeCliente { get; set; }
        public string DataCompra { get; set; }
        public double PrecoCompra { get; set; }

    }
}
