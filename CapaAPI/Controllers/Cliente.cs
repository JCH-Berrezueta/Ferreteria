
using CapaLogica.Gestion;
using System.Web.Http;
using ClienteLN = CapaLogica.Gestion.ClienteLN;

namespace CapaAPI.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        public ClienteController()
        {

        }

        [HttpGet]
        [Route("listar-cliente")]
        public IHttpActionResult ObtenerClientes()
        {
            // Aquí estamos llamando a la capa lógica para obtener los productos
            var productos = ClienteLN.listarClientesLN();
            return Ok(productos);  // Retornamos la lista de productos
        }
    }
}