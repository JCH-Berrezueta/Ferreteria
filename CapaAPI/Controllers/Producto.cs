
using System.Web.Http;
using ProductoLN = CapaLogica.Gestion.ProductoLN;

namespace PresentacionWeb.Controllers
{
    [RoutePrefix("api/producto")]
    public class ProductoController : ApiController
    {
        public ProductoController()
        {

        }

        [HttpGet]
        [Route("obtener-productos")]
        public IHttpActionResult ObtenerProductos()
        {
            // Aquí estamos llamando a la capa lógica para obtener los productos
            var productos = ProductoLN.listarProductosLN();
            return Ok(productos);  // Retornamos la lista de productos
        }
    }
}