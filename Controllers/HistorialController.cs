using Microsoft.AspNetCore.Mvc;

namespace Mv.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}