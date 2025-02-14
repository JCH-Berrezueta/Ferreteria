using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using ClienteLN = CapaLogica.Gestion.ClienteLN;
namespace CapaAPI.Controllers
{
    [RoutePrefix("api/cliente")]
    public class Cliente : ApiController
    {
        public Cliente()
        {
        }
        [HttpGet]
        [Route("obtener-clientes")]
        public IHttpActionResult ObtenerClientes()
        {
           var clientes = ClienteLN.listarClientesLN();
            return Ok(clientes);  // Retornamos la lista de clientes
        }
    }
}
