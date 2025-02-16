
using System.Web.Http;
using RolLN = CapaLogica.Seguridad.RolLN;

namespace CapaAPI.Controllers
{
    [RoutePrefix("api/rol")]
    public class RolController : ApiController
    {
        public RolController()
        {

        }

        [HttpGet]
        [Route("listar-rol")]
        public IHttpActionResult ObtenerRoles()
        {
            // Aqu� estamos llamando a la capa l�gica para obtener los productos
            var productos = RolLN.listarVistaRolLN();
            return Ok(productos);  // Retornamos la lista de productos
        }
    }
}