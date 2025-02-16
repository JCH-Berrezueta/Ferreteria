using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PresentacionWeb.Repositorio;
using CapaEntidades.Gestion;

namespace PresentacionWeb.Pages
{
    public class CategoriaModel : PageModel
    {
        private readonly ILogger<CategoriaModel> _logger;
        private readonly CategoriaRepository _categoriaRepository; // Añadido  

        public List<Categoria> Categorias { get; set; } // Propiedad para almacenar las categorías  

        public CategoriaModel(ILogger<CategoriaModel> logger, CategoriaRepository categoriaRepository) // Inyección del repositorio  
        {
            _logger = logger;
            _categoriaRepository = categoriaRepository; // Inicializa el repositorio  
        }
        public void OnGet()
        {
            Categorias = _categoriaRepository.ObtenerCategorias();
        }

        public IActionResult OnPostCrear(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                ModelState.AddModelError("Nombre", "El nombre es obligatorio.");
                return Page();
            }

            _categoriaRepository.InsertarCategoria(nombre, descripcion);
            return RedirectToPage(); // Redirigir para refrescar la lista  
        }
        public void OnPostInsert(string nombre, string descripcion)
        {
            _categoriaRepository.InsertarCategoria(nombre, descripcion);
        }

        public void OnPostModificar(int id, string nombre, string descripcion)
        {
            _categoriaRepository.ModificarCategoria(id, nombre, descripcion);
        }

        public IActionResult OnPostEliminar(int id)
        {
            if (id <= 0)
            {
                return BadRequest(); // O error que adecuadamente indique un ID inválido  
            }

            _categoriaRepository.EliminarCategoria(id);
            return RedirectToPage(); // Redirigir para refrescar la lista  
        }
    }
}
