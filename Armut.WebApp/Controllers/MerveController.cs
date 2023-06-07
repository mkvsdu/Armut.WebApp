using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class MerveController : Controller
    {
        [Route("merve")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
