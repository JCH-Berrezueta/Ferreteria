using CapaEntidades.Gestion;
using CapaLogica.Seguridad;
using System;
using System.Web.Http;

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
        [Route("autenticar")]
        public IHttpActionResult autenticarCuenta([FromBody] Cuenta cuenta)
        {
            try
            {
                bool resul = CuentaLN.autenticarCuentaLN(cuenta);
                return Ok(resul);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return InternalServerError(ex);
            }
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
        [Route("getMail")]
        public IHttpActionResult getMailCuenta(string mail, string password)
        {
            try
            {
                // Aquí estamos llamando a la capa lógica para obtener las cuentas
                var cuentas = CuentaLN.filtrarCuentasLN(mail, password);
                return Ok(cuentas);  // Retornamos la lista de cuentas
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("getId")]
        public IHttpActionResult getIdCuenta(Cuenta cuenta)
        {
            // Aquí estamos llamando a la capa lógica para obtener las cuentas
            var idCuenta = CuentaLN.getIdCuentaLN(cuenta.Mail, cuenta.Password);
            return Ok(idCuenta);  // Retornamos la lista de cuentas
        }
    }
}
