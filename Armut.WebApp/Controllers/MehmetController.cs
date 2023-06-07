using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class MehmetController : Controller
    {

        [Route("Mehmet")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
