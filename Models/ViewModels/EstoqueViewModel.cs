using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class EstoqueViewModel
    {
        public List<int> id { get; set; }

        public List<int> quantidade { get; set; }

        public List<int> fornecedor { get; set; }
    }
}
