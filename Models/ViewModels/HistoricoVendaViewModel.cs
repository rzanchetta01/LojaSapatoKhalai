using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace lojaSapato.Models.ViewModels
{
    
    public class HistoricoVendaViewModel
    {
        public int id { get; set; }
        public string NomeModelo { get; set; }

        public string NomeFornecedor { get; set; }

        public double PrecoModelo { get; set; }

        public int Quantidade { get; set; }

        public string Categoria { get; set; }

        public double PrecoCompra { get; set; }

        public string DataVenda { get; set; }
    }
}
