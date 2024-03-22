using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}