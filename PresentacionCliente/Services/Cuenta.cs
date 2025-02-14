using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadCuenta = CapaEntidades.Gestion.Cuenta;
namespace PresentacionCliente.Services
{
    public class Cuenta
    {
        private readonly HttpClient _httpClient;
        public Cuenta()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }
        public async Task<List<EntidadCuenta>> ObtenerCuentas()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/cuenta/obtener-cuentas");
            Debug.WriteLine("Intentanto");
            // Deserializamos la respuesta JSON en una lista de productos
            var cuentas = JsonConvert.DeserializeObject<List<EntidadCuenta>>(response);
            return cuentas;
        }
    }
}
