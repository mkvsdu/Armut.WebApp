using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
    public class BeyzaController : Controller
    {
        [Route("beyza")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
