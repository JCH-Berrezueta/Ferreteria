using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;  // Esto es necesario para que JsonConvert funcione

using EntidadProducto = CapaEntidades.Gestion.Producto;

namespace PresentacionWeb.Services
{
    public class Producto
    {
        private readonly HttpClient _httpClient;

        public Producto()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<EntidadProducto>> ObtenerProductos()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/producto/obtener-productos");
            Debug.WriteLine("Intentanto");
            // Deserializamos la respuesta JSON en una lista de productos
            var productos = JsonConvert.DeserializeObject<List<EntidadProducto>>(response);
            return productos;
        }
    }
}
