using Estacionamento.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers
{
    public class VeiculoController : Controller
    {
        [HttpGet]
        public IActionResult Index(){    
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            VeiculoModel veiculo = new VeiculoModel(
            nome:form["nome"],
            modelo:form["modelo"],
            marca:form["marca"],
            placa:form["placa"] 
            );
            
            return View("");
        }
    }
}