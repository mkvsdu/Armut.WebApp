using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class KeremController : Controller
    {
        [Route("/kerem")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
