using System;
using Hamburgueria.Repositories;
using Hmaburgueria_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Hmaburgueria_MVC.Controllers {
    public class CadastroController : Controller {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index () {
            ViewData["NomeView"] = "Cadastro";
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            Cliente cliente = new Cliente ();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepository.Inserir(cliente);

            ViewData["Action"] = "Cadastro";
            return View ("Sucesso");
        }
    }
}