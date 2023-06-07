using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class Aleyna : Controller
    {
        [Route("aleyna")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
