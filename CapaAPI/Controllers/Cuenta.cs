using CapaEntidades.Gestion;
using System;
using System.Web.Http;
using CuentaLN= CapaLogica.Seguridad.CuentaLN;
using cuentasss = CapaEntidades.Gestion.Cuenta;
namespace CapaAPI.Controllers
{
    [RoutePrefix("api/cuenta")]
    public class CuentaController : ApiController
    {
        public CuentaController()
        {
        }

        [HttpGet]
        [Route("listar")]

        public IHttpActionResult ObtenerCuentas()
        {
            // Aquí estamos llamando a la capa lógica para obtener las cuentas
            var cuentas = CuentaLN.listarCuentasLN();
            return Ok(cuentas);  // Retornamos la lista de cuentas
        }


        [HttpPost]
        [Route("crear")]
        public IHttpActionResult CrearCliente([FromBody] Cuenta nuevoCliente)
        {
            if (nuevoCliente != null)
            {
                try
                {
                    // Aquí estamos llamando a la capa lógica para crear el cliente
                    var resultado = CapaLogica.Seguridad.CuentaLN.insertarCuentaLN(nuevoCliente);

                    if (resultado)
                    {
                        return Ok("Cliente creado exitosamente.");
                    }
                    else
                    {
                        return InternalServerError();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    return InternalServerError(ex);
                }
            }
            else
            {
                return BadRequest("El cliente no puede ser nulo.");
            }
        }

        [HttpGet]
        [Route("getId")]

        public IHttpActionResult getIdCuenta(string Mail,string Password)
        {
            // Aquí estamos llamando a la capa lógica para obtener las cuentas
            var cuentas = CuentaLN.getIdCuenta(Mail,Password);
            return Ok(cuentas);  // Retornamos la lista de cuentas
        }

        

    }
}
