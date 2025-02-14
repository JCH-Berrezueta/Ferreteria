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
                // Aquí puedes agregar la lógica de autenticación.
                if (Username == "usuario" && Password == "contraseña")
                {
                    // Redirigir a la página principal o a otra página si la autenticación es exitosa.
                    return RedirectToPage("/Home");
                }

                ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos");
            }

            // Si la autenticación falla, volver a la página de login.
            return Page();
        }
    }
}
