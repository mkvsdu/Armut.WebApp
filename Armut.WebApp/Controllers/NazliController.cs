using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class NazliController : Controller
    {
        [Route("nazli")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
