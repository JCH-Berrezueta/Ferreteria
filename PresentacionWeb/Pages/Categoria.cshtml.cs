using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentacionWeb.Pages
{
    public class CategoriaModel : PageModel
    {

        private readonly ILogger<CategoriaModel> _logger;
        public CategoriaModel(ILogger<CategoriaModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
