using CapaEntidades.Gestion;
using System;
using System.Diagnostics;
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

        

        [HttpPost]
        [Route("crear")]
        public IHttpActionResult CrearCliente([FromBody] Cliente nuevoCliente)
        {
            Debug.WriteLine(nuevoCliente.IdCuenta);
            if (nuevoCliente != null)
            {
                try
                {
                    // Aquí estamos llamando a la capa lógica para crear el cliente
                    var resultado = CapaLogica.Gestion.ClienteLN.insertarClienteLN(nuevoCliente);

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
    }
}
