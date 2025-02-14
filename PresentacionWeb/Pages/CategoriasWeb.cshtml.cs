using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentacionWeb.Pages
{
    public class CategoriasWebModel : PageModel
    {
        private readonly ILogger<CategoriasWebModel> _logger;

        public CategoriasWebModel(ILogger<CategoriasWebModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
