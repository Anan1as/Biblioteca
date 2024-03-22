using Microsoft.AspNetCore.Mvc;

namespace Mv.Controllers
{
    public class UsuariosController : Controller
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