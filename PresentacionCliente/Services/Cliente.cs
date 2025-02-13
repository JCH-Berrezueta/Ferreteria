using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadCliente= CapaEntidades.Gestion.Cliente;
using Newtonsoft.Json;
using System.Diagnostics;
namespace PresentacionCliente.Services
{
    public class Cliente
    {
        private readonly HttpClient _httpClient;

        public Cliente()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<EntidadCliente>> ObtenerClientes()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/cliente/obtener-clientes");
            Debug.WriteLine("Intentanto");
            // Deserializamos la respuesta JSON en una lista de productos
            var clientes = JsonConvert.DeserializeObject<List<EntidadCliente>>(response);
            return clientes;
        }
    }
}
