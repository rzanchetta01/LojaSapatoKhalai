using System.Collections.Generic;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class VendaViewModel
    {

        public List<string> NomeModelo { get; set; }
        public List<string> NomeFornecedor { get; set; }
        public List<double> PrecoModelo { get; set; }
        public List<string> CodigoRefModelo { get; set; }
        public double PrecoCompra { get; set; }

    }
}
