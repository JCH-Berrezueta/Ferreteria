using System.Web.Http;
using CuentaLN= CapaLogica.Seguridad.CuentaLN;
namespace CapaAPI.Controllers
{
    [RoutePrefix("api/cuenta")]
    public class Cuenta : ApiController
    {
        public Cuenta()
        {
        }

        [HttpGet]
        [Route("listar-cuentas")]

        public IHttpActionResult ObtenerCuentas()
        {
            // Aqu� estamos llamando a la capa l�gica para obtener las cuentas
            var cuentas = CuentaLN.listarCuentasLN();
            return Ok(cuentas);  // Retornamos la lista de cuentas
        }
    }
}
