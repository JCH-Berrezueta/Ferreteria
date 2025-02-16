using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentacionWeb.Pages
{
    public class CuentaModel : PageModel
    {
        private readonly ILogger<CuentaModel> _logger;
        public CuentaModel(ILogger<CuentaModel> logger)
        {
            _logger = logger;
        }



        public void OnGet()
        {
        }
    }
}
