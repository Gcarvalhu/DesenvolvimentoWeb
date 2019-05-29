using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TskukarWeb.Models;
using TskukarWeb.Repositorio;
using TskukarWeb.ViewModels;

namespace TskukarWeb.Controllers
{
    public class HomeController : Controller
    {
        private MarcasRepositorio marcasRepositorio = new MarcasRepositorio();
        [HttpGet]
        public IActionResult Index()
        {
            var marcasRecuperadas = marcasRepositorio.Listar();

            CondutorViewModels condutor = new CondutorViewModels();
            condutor.marcas = marcasRecuperadas;
            return View(condutor);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
