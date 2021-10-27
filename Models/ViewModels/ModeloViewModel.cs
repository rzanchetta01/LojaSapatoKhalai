using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class ModeloViewModel
    {
        public string Nome { get; set;}

        public List<int> Tamanhos { get; set; }

        public List<string> Cores { get; set; }

        public float Preco { get; set;}

        public string Descricao { get; set; }

        public  List<string> Comentarios { get; set; }
    }
}
