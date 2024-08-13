using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
