using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
[HttpPost]
        public IActionResult SignIn(string email, string password)
        {
            // Here, you would typically validate the user's credentials
            // This is a simplified example for illustration purposes
            if (email == "test@example.com" && password == "password")
            {
                // Redirect to a secure page, for example, the user's dashboard
                return RedirectToAction("Dashboard", "Home");
            }

            // If login fails, show an error message
            ViewBag.ErrorMessage = "Invalid email or password";
            return View();
        }

        // Display the SignUp page
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        // Handle the SignUp form submission
        [HttpPost]
        public IActionResult SignUp(string name, string email, string password)
        {
            // Here, you would typically create a new user in the database
            // This is a simplified example for illustration purposes
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Normally, you'd save the new user to the database here

                // Redirect to the SignIn page after successful registration
                return RedirectToAction("SignIn");
            }

            // If registration fails, show an error message
            ViewBag.ErrorMessage = "Registration failed. Please try again.";
            return View();
        }
    }
    }
}
