using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;  // Esto es necesario para que JsonConvert funcione

using EntidadProducto = CapaEntidades.Gestion.Producto;
using VistaProducto = CapaEntidades.Vistas.VProductoCategoria;

namespace PresentacionCliente.Services
{
    public class Producto
    {
        private readonly HttpClient _httpClient;

        public Producto()
        {
            _httpClient = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<VistaProducto>> listarVistaProductos()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/producto/listar-vista-productos");
            // Deserializamos la respuesta JSON en una lista de productos
            var productos = JsonConvert.DeserializeObject<List<VistaProducto>>(response);
            return productos;
            // nose nada de esto
        }
    }
}
