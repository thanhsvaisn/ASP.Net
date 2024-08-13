using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
	public class CreateController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
