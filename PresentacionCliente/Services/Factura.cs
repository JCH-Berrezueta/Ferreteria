using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFactura = CapaEntidades.Gestion.Factura;
namespace PresentacionCliente.Services
{
    public class Factura
    {
        private readonly HttpClient _httpClient;

        public Factura()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<EntidadFactura>> ObtenerProductos()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/producto/obtener-productos");
            Debug.WriteLine("Intentanto");
            // Deserializamos la respuesta JSON en una lista de productos
            var productos = JsonConvert.DeserializeObject<List<EntidadFactura>>(response);
            return productos;
        }
    }
}
