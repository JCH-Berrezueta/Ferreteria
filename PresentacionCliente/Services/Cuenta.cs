using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistaCuenta= CapaEntidades.Gestion.Cuenta;
namespace PresentacionCliente.Services
{
    class Cuenta
    {
        private readonly HttpClient _httpClient;

        public Cuenta()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<VistaCuenta>> listarVistaCuenta()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/Cuenta/listar-cuentas");
            // Deserializamos la respuesta JSON en una lista de productos
            var productos = JsonConvert.DeserializeObject<List<VistaCuenta>>(response);
            return productos;
            // nose nada de esto
        }
    }
}
