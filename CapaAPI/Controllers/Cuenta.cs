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
            // Aquí estamos llamando a la capa lógica para obtener las cuentas
            var cuentas = CuentaLN.listarCuentasLN();
            return Ok(cuentas);  // Retornamos la lista de cuentas
        }
    }
}
