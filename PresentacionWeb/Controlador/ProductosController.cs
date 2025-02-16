using CapaEntidades.Gestion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentacionWeb.Repositorio;

namespace PresentacionWeb.Controlador
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : Controller
    {
        private readonly ProductosRepository _productoRepository;

        public ProductosController(ProductosRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public IActionResult Producto()
        {
            var productos = _productoRepository.ObtenerProducto();
            return View(productos);
        }
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Producto nuevaProducto)
        {
            if (ModelState.IsValid)
            {
                _productoRepository.InsertarProducto(nuevaProducto.IdCategoriaProducto,nuevaProducto.Nombre,nuevaProducto.Precio,nuevaProducto.Stock,nuevaProducto.Estado,nuevaProducto.Icono,nuevaProducto.Descripcion);
                return RedirectToAction("Producto");
            }
            return View(nuevaProducto);
        }
        [HttpGet("Editar/{id}")] // Método GET para editar  
        public IActionResult Editar(int id)
        {
            var producto = _productoRepository.ObtenerProducto().FirstOrDefault(c => c.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpPost("Editar")] // Método POST para editar  
        public IActionResult Editar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _productoRepository.ModificarProducto(producto.IdCategoriaProducto, producto.Nombre, producto.Precio, producto.Stock, producto.Estado, producto.Icono, producto.Descripcion);
                return RedirectToAction("Categoria");
            }
            return View(producto);
        }


        [HttpPost] // Asegúrate de que es un POST si estás eliminando directamente  
        public IActionResult Eliminar(int id)
        {
            _productoRepository.EliminarProducto(id);
            return RedirectToAction("Categoria"); // Redirige después de eliminar  
        }


    }
}
