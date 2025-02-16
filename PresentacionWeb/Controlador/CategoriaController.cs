using CapaEntidades.Gestion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PresentacionWeb.Repositorio;

namespace PresentacionWeb.Controlador
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaController(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Categoria()
        {
            var categorias = _categoriaRepository.ObtenerCategorias();
            return View(categorias);
        }
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Categoria nuevaCategoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.InsertarCategoria(nuevaCategoria.Nombre, nuevaCategoria.Descripcion);
                return RedirectToAction("Categoria");
            }
            return View(nuevaCategoria);
        }
        [HttpGet("Editar/{id}")] // Método GET para editar  
        public IActionResult Editar(int id)
        {
            var categoria = _categoriaRepository.ObtenerCategorias().FirstOrDefault(c => c.IdCategoria == id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        [HttpPost("Editar")] // Método POST para editar  
        public IActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaRepository.ModificarCategoria(categoria.IdCategoria, categoria.Nombre, categoria.Descripcion);
                return RedirectToAction("Categoria");
            }
            return View(categoria);
        }


        [HttpPost] // Asegúrate de que es un POST si estás eliminando directamente  
        public IActionResult Eliminar(int id)
        {
            _categoriaRepository.EliminarCategoria(id);
            return RedirectToAction("Categoria"); // Redirige después de eliminar  
        }
    }
}
