using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSapatoKhalai.Models.ViewModels
{
    public class VendaViewModel
    {
       public list <string> codigoRef {get; set; } 
        
       public list <int> id_modelo {get; set; } 
        
       public list <string> nome_model {get; set; } 
        
       public list <string> nome_fornecedor {get; set; }
        
        public list <int> tamanho_modelo {get; set; }
        
        public list <string> cor_modelo {get; set; }
        
        public list <float> valorItem {get; set; }
        
        public list <int> quantidade {get; set; }
        
        public int id_cliente {get; set; }
        
        public string nome_cliente {get; set; }
        
        public DateTime dtVenda  {get; set; }
        
        public float total  {get; set; }
        
        
        


        
    }
}
