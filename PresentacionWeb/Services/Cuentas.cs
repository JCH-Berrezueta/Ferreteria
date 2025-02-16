using Newtonsoft.Json;
using System.Diagnostics;
using EntidadCuenta = CapaEntidades.Gestion.Cuenta;
namespace PresentacionWeb.Services
{
    public class Cuentas
    {
        private readonly HttpClient _httpClient;

        public Cuentas()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<EntidadCuenta>> ObtenerCuentas()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/cuenta/listar-cuentas");
            Debug.WriteLine("Intentanto");
            // Deserializamos la respuesta JSON en una lista de cuentas
            var cuentass = JsonConvert.DeserializeObject<List<EntidadCuenta>>(response);
            return cuentass;
        }
    }
    
}
