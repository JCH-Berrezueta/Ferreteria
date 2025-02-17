﻿
using System.Web.Http;
using ProductoLN = CapaLogica.Gestion.ProductoLN;

namespace CapaAPI.Controllers
{
    [RoutePrefix("api/producto")]
    public class ProductoController : ApiController
    {
        public ProductoController()
        {

        }

        [HttpGet]
        [Route("listar-vista-productos")]
        public IHttpActionResult ObtenerProductos()
        {
            // Aquí estamos llamando a la capa lógica para obtener los productos
            var productos = ProductoLN.listarVistaProductosLN();
            return Ok(productos);  // Retornamos la lista de productos
        }
    }
}