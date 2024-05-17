using Microsoft.AspNetCore.Mvc;

namespace ProjectInsat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
