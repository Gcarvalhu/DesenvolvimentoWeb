using Microsoft.Extensions.Primitives;

namespace Hmaburgueria_MVC.Models
{
    public class Hamburguer : Produto
    {
        public Hamburguer()
        {
        }

        public Hamburguer(StringValues Nome,double Preço)
        {
            this.Nome = Nome;
            this.Preço = Preço;
        }
    }
}