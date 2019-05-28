using Documents.DesenvolvimentoWeb.Models;
using Hmaburgueria_MVC.Models;
using Hmaburgueria_MVC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hmaburgueria_MVC.Controllers {
    public class PedidoController : Controller {
        
        private PedidoRepositorio Repositorio = new PedidoRepositorio();

        private HamburguerRepositorio hamburguerRepositorio = new HamburguerRepositorio();

        private ShakeRepositorio shakeRepositorio = new ShakeRepositorio();

        [HttpGet]
        public IActionResult Index () {

            var hamburgueres = hamburguerRepositorio.Listar();
            var shakes = shakeRepositorio.Listar();

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburgueres;
            pedido.Shakes = shakes;

            return View (pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido (IFormCollection form) 
        {
            System.Console.WriteLine (form["nome"]);
            System.Console.WriteLine (form["endereço"]);
            System.Console.WriteLine (form["telefone"]);
            System.Console.WriteLine (form["email"]);
            System.Console.WriteLine (form["hamburguer"]);
            System.Console.WriteLine (form["shake"]);

            Pedido pedido = new Pedido();
            //Forma 1 - mais comum
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            //forma 2 - Usa parametros nos construtores
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"],
                Preço: hamburguerRepositorio.ObterPrecoDe(form["hamburguer"])
            );

            pedido.Hamburguer = hamburguer;

            Shake shake = new Shake(){
                Nome = form ["shake"],
                Preço = shakeRepositorio.ObterPrecoDe(form["shake"])

            };
    
            pedido.Shake = shake;

            pedido.PrecoTotal = pedido.Hamburguer.Preço + pedido.Shake.Preço;

            Repositorio.Inserir(pedido);
            ViewData["NomeView"] = "Pedido";

            return View("Sucesso");
        }
    }
}