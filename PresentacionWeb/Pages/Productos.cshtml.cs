using CapaEntidades.Gestion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PresentacionWeb.Repositorio;

namespace PresentacionWeb.Pages
{
    public class ProductosModel : PageModel
    {
        private readonly ILogger<ProductosModel> _logger;
        private readonly ProductosRepository _productoRepository; // Añadido  

        public List<Producto> Productos { get; set; } // Propiedad para almacenar las categorías  

        public ProductosModel(ILogger<ProductosModel> logger, ProductosRepository productoRepository) // Inyección del repositorio  
        {
            _logger = logger;
            _productoRepository = productoRepository; // Inicializa el repositorio  
        }
        public void OnGet()
        {
            Productos = _productoRepository.ObtenerProducto();
        }

        public IActionResult OnPostCrear(int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                ModelState.AddModelError("Nombre", "El nombre es obligatorio.");
                return Page();
            }

            _productoRepository.InsertarProducto( idCategoriaProducto,  nombre, precio, stock,  estado, icono,descripcion);
            return RedirectToPage(); 
        }
        public void OnPostInsert(int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            _productoRepository.InsertarProducto(idCategoriaProducto, nombre, precio, stock, estado, icono, descripcion);
        }

        public void OnPostModificar(int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            _productoRepository.ModificarProducto(idCategoriaProducto, nombre, precio, stock, estado, icono, descripcion);
        }

        public IActionResult OnPostEliminar(int id)
        {
            if (id <= 0)
            {
                return BadRequest(); // O error que adecuadamente indique un ID inválido  
            }

            _productoRepository.EliminarProducto(id);
            return RedirectToPage(); // Redirigir para refrescar la lista  
        }
    }
}
