using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
