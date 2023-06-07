using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class ErenController : Controller
    {
        [Route("Eren")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
