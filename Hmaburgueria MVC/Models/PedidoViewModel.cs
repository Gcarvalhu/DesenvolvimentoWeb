using System.Collections.Generic;
using Hmaburgueria_MVC.Models;

namespace Documents.DesenvolvimentoWeb.Models
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get;set;}
    }
}