using CapaEntidades.Gestion;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PresentacionWeb.Repositorio;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;

namespace PresentacionWeb.Pages
{
    public class ProductosModel : PageModel
    {
        private readonly ILogger<ProductosModel> _logger;
        private readonly ProductosRepository _productoRepository;

        public List<Producto> Productos { get; set; }

        [BindProperty]
        public IFormFile Icono { get; set; } // Para recibir el archivo de imagen

        public ProductosModel(ILogger<ProductosModel> logger, ProductosRepository productoRepository)
        {
            _logger = logger;
            _productoRepository = productoRepository;
        }

        public void OnGet()
        {
            Productos = _productoRepository.ObtenerProducto();
        }

        public IActionResult OnPostCrear(int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                ModelState.AddModelError("Nombre", "El nombre es obligatorio.");
                return Page();
            }

            string fileName = null;
            if (Icono != null && Icono.Length > 0)
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                fileName = Guid.NewGuid().ToString() + Path.GetExtension(Icono.FileName);
                string filePath = Path.Combine(uploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Icono.CopyTo(fileStream);
                }
            }

            _productoRepository.InsertarProducto(idCategoriaProducto, nombre, precio, stock, estado, fileName, descripcion);

            return RedirectToPage();
        }

        public IActionResult OnPostEliminar(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _productoRepository.EliminarProducto(id);
            return RedirectToPage();
        }
    }
}

