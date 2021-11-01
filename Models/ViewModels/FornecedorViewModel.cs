using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class FornecedorViewModel
    {
        public List <string> Nome { get; set; }
        public List <string> CNPJ { get; set; }
        public List <string> Endereco { get; set; }
    }
}
