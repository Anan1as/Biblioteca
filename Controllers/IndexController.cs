using Microsoft.AspNetCore.Mvc;

namespace Mv.Controllers
{
    public class IndexController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }

}