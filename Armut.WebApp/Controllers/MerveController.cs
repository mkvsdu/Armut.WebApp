using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class MerveController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
