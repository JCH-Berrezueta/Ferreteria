using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PresentacionWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Aqu� puedes agregar la l�gica de autenticaci�n.
                if (Username == "usuario" && Password == "contrase�a")
                {
                    // Redirigir a la p�gina principal o a otra p�gina si la autenticaci�n es exitosa.
                    return RedirectToPage("/Home");
                }

                ModelState.AddModelError(string.Empty, "Usuario o contrase�a incorrectos");
            }

            // Si la autenticaci�n falla, volver a la p�gina de login.
            return Page();
        }
    }
}
