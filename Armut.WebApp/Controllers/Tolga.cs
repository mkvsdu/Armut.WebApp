using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class Tolga : Controller
    {
        [Route("tolga")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
