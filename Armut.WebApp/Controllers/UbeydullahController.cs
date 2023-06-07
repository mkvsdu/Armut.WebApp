using Microsoft.AspNetCore.Mvc;

namespace Armut.WebApp.Controllers
{
	public class UbeydullahController : Controller
	{
		[Route("ubeydullah")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
