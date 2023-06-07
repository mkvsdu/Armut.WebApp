using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class BuketController : Controller
    {
        [Route("buket")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
