using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VistaCuenta= CapaEntidades.Gestion.Cuenta;
namespace PresentacionCliente.Services
{
    public class Cuenta
    {
        private readonly HttpClient _httpCuenta;

        public Cuenta(HttpClient httpCuenta)
        {
            _httpCuenta = new HttpClient();  // Inicializamos HttpClient
        }

        public async Task<List<VistaCuenta>> listarVistaCuenta()
        {
            // Hacemos una solicitud GET a la API Web
            var response = await _httpCuenta.GetStringAsync("https://localhost:44386/api/Cuenta/listar");
            // Deserializamos la respuesta JSON en una lista de productos
            var cuentas = JsonConvert.DeserializeObject<List<VistaCuenta>>(response);
            return cuentas;
            // nose nada de esto
        }

        public async Task<bool> CrearCuenta(VistaCuenta nuevaCuenta)
        {
            var jsonContent = JsonConvert.SerializeObject(nuevaCuenta);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpCuenta.PostAsync("https://localhost:44386/api/cuenta/crear", content);
            return response.IsSuccessStatusCode;
        }
        public async Task<int> getIdCuenta(VistaCuenta cuenta)
        {
            var jsonContent = JsonConvert.SerializeObject(cuenta);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpCuenta.PostAsync("https://localhost:44386/api/Cuenta/getId", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var idCuenta = JsonConvert.DeserializeObject<int>(responseContent);
                return idCuenta;
            }
            else
            {
                // Manejo de errores (por ejemplo, lanzar una excepción o retornar un valor por defecto)
                throw new Exception("Error al obtener el ID de la cuenta.");
            }
        }


        public async Task<bool> AutenticarCuenta(VistaCuenta cuenta)
        {
            bool resul = false;
            try
            {
                var jsonContent = JsonConvert.SerializeObject(cuenta);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _httpCuenta.PostAsync("https://localhost:44386/api/cuenta/autenticar", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    resul = JsonConvert.DeserializeObject<bool>(responseContent);
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error Autenticar Cuenta: " + error);
            }
            return resul;
        }



    }
}
