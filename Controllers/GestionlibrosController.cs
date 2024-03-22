using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class GestionlibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Actualizar()
        {
            return View();
        }
    }
}