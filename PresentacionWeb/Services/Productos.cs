using Newtonsoft.Json;

namespace PresentacionWeb.Services
{
    public class Productos
    {
        private readonly HttpClient _httpClient;

        public async Task<List<Productos>> ObtenerProducto()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/producto/listar-producto");
            var productos = JsonConvert.DeserializeObject<List<Productos>>(response);
            return productos;
        }
    }
}

