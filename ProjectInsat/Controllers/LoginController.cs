using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjectInsat.Controllers
{
    public class LoginController : Controller
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; private set; }

        public IActionResult OnPost()
        {
            // Here you would validate the username and password.
            // For simplicity, let's say the username is "admin" and the password is "password".
            if (Username == "admin" && Password == "password")
            {
                // If the username and password are correct, you can redirect the user to another page.
                return RedirectToPage("/Index"); // Redirect to the Index page
            }
            else
            {
                // If the username or password is incorrect, show an error message.
                ErrorMessage = "Invalid username or password.";
                //   return Page();
                return RedirectToPage("/Login");// Stay on the login page and display the error message.
            }
        }
    }
}


