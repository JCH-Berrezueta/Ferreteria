using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        [Route("obtener-cuentas")]
        public IHttpActionResult ObtenerCuentas()
        {
            var cuentas = CuentaLN.listarCuentasLN();
            return Ok(cuentas);
        }
    }
}
