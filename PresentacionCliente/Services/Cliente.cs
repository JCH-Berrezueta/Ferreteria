using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistaCliente = CapaEntidades.Gestion.Cliente;
namespace PresentacionCliente.Services
{
    public class Cliente
    {
        private readonly HttpClient _httpCliente;

        public Cliente(HttpClient httpClient)
        {
            _httpCliente = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<VistaCliente>> listarVistaCliente()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpCliente.GetStringAsync("https://localhost:44386/api/cliente/listar");
            // Deserializamos la respuesta JSON en una lista de productos
            var clientes = JsonConvert.DeserializeObject<List<VistaCliente>>(response);
            return clientes;
            // nose nada de esto
        }

        public async Task<bool> CrearCliente(VistaCliente nuevaCuenta)
        {
            var jsonContent = JsonConvert.SerializeObject(nuevaCuenta);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpCliente.PostAsync("https://localhost:44386/api/cuenta/crear", content);
            return response.IsSuccessStatusCode;
        }

    }
}
