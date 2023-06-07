using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class KökerController : Controller
    {
        [Route("koker")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
