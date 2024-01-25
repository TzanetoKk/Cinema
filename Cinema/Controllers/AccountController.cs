using Microsoft.AspNetCore.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Check if model state is valid
            if (ModelState.IsValid)
            {
                // Authenticate user based on the provided credentials
                if (IsValidUser(model.Username, model.Password))
                {
                    // Redirect users based on their roles
                    if (IsSuperAdmin(model.Username))
                    {
                        // Super Admin role
                        // Set authentication cookie and redirect to admin dashboard
                        // Example: HttpContext.SignInAsync(...);
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (IsContentAdmin(model.Username))
                    {
                        // Content Admin role
                        // Set authentication cookie and redirect to content admin dashboard
                        // Example: HttpContext.SignInAsync(...);
                        return RedirectToAction("Index", "ContentAdmin");
                    }
                    else
                    {
                        // Regular User role
                        // Set authentication cookie and redirect to user dashboard
                        // Example: HttpContext.SignInAsync(...);
                        return RedirectToAction("Index", "User");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                }
            }

            // If we reach here, the model state is not valid or authentication failed
            return View(model);
        }

        public IActionResult Logout()
        {
            // Clear authentication cookie
            // Example: HttpContext.SignOutAsync(...);

            // Redirect users to the login page
            return RedirectToAction("Login");
        }

        // Example method to validate user credentials
        private bool IsValidUser(string username, string password)
        {
            // Implement your logic to validate user credentials
            // Check against your predefined users
            // Return true if credentials are valid, otherwise false
            // Example: Check against a database or predefined users list
            return (username == "User1" && password == "123") ||
                   (username == "ContentAdmin1" && password == "321") ||
                   (username == "SuperAdmin" && password == "12345");
        }

        // Example method to check if user is a Super Admin
        private bool IsSuperAdmin(string username)
        {
            // Check if the username corresponds to a Super Admin
            return username == "SuperAdmin";
        }

        // Example method to check if user is a Content Admin
        private bool IsContentAdmin(string username)
        {
            // Check if the username corresponds to a Content Admin
            return username == "ContentAdmin1";
        }
    }
}
