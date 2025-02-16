using Newtonsoft.Json;
using System.Net.Http;

namespace PresentacionWeb.Services
{
    public class Categoria
    {
        private readonly HttpClient _httpClient;

        public async Task<List<Categoria>> ObtenerCategorias()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:44386/api/categoria/listar-categorias");
            var categorias = JsonConvert.DeserializeObject<List<Categoria>>(response);
            return categorias;
        }
    }
}
