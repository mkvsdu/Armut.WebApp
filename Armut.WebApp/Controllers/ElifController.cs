using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class ElifController : Controller
    {
        [Route("elif")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
