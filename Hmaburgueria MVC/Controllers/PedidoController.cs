using Microsoft.AspNetCore.Mvc;

namespace Hmaburgueria_MVC.Controllers
{
    public class PedidoController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }
    }
}