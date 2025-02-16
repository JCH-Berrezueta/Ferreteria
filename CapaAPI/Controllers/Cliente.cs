using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace CapaAPI.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        public ClienteController()
        {
        }
        [HttpGet]
        [Route("listar")]
        public IHttpActionResult ObtenerClientes()
        {
            // Aquí estamos llamando a la capa lógica para obtener los clientes
            var clientes = CapaLogica.Gestion.ClienteLN.listarClientesLN();
            return Ok(clientes);  // Retornamos la lista de clientes
        }
    }
}
