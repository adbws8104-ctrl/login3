using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Configuration;
namespace login.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Email == "test@gmail.com" && Password == "123456")
            {
                return RedirectToPage("/Home");
            }

            ErrorMessage = "Incorrect email address or password";
            return Page();
        }
    }
}
