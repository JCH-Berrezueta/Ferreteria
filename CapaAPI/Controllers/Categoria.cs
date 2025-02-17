using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using CategoriaLN= CapaLogica.Gestion.CategoriaLN;
namespace CapaAPI.Controllers
{
    [RoutePrefix("api/categoria")]
    public class CategoriaController : ApiController
    {
        public CategoriaController()
        {
        }
        [HttpGet]
        [Route("listar")]
        public IHttpActionResult ObtenerCategorias()
        {
            // Aquí estamos llamando a la capa lógica para obtener los categoria
            var clientes = CategoriaLN.listarCategoriaLN();
            return Ok(clientes);  // Retornamos la lista de clientes
        }

    }
}
