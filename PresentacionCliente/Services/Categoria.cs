using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Vcategoria=CapaEntidades.Gestion.Categoria;
namespace PresentacionCliente.Services
{
    public class Categoria
    {
        private readonly HttpClient _httpCategoria;


        public Categoria()
        {
            _httpCategoria = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<Vcategoria>> listarVistaCliente()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpCategoria.GetStringAsync("https://localhost:44386/api/categoria/listar");
            // Deserializamos la respuesta JSON en una lista de productos
            var clientes = JsonConvert.DeserializeObject<List<Vcategoria>>(response);
            return clientes;
            // nose nada de esto
        }
    }


}
