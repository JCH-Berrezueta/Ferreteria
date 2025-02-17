using System.Threading.Tasks;
using CapaEntidades.Gestion;
using CapaLogica.Seguridad;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;
using CapaAPI.Controllers;
using PresentacionCliente.Services;
using cuentass = CapaEntidades.Gestion.Cuenta;
namespace PresentacionCliente.VSecundary
{
    
    public partial class VRegister : ContentPage
    {
        private readonly PresentacionCliente.Services.Cliente _httpClient;
        private readonly PresentacionCliente.Services.Cuenta _httpCuenta;
        public VRegister()
        {
            InitializeComponent();
            var httpCliente = new HttpClient();
            _httpClient = new PresentacionCliente.Services.Cliente(httpCliente);
            var httpCuenta = new HttpClient();
            _httpCuenta = new PresentacionCliente.Services.Cuenta(httpCuenta);

        }

        protected override bool OnBackButtonPressed()
        {
            // No permitir navegar hacia atrás
            return true;
        }


        private async Task Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Cambios cancelados", "OK");
            await Navigation.PopAsync();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {

            var cuen = new CapaEntidades.Gestion.Cuenta
            {
                IdRol = 1, // Asigna el rol apropiado
                Mail = corre.Text,
                Password = corra.Text
            };

            // Llama al método para crear la cuenta y obtener el objeto de la cuenta creada
            var cuentaCreada = await _httpCuenta.CrearCuenta(cuen);

            if (cuentaCreada != null)
            {
                var cliente = new CapaEntidades.Gestion.Cliente
                {
                    IdCuenta = , // Asigna el IdCuenta generado
                    Nombre = nomb.Text,
                    Apellido = ape.Text,
                    FechaNacimiento = fech.Date,
                    Edad = CalcularEdad(fech.Date),
                    Telefono = tele.Text
                };

                // Llama al método para crear el cliente
                var resultadoCliente = await _httpClient.CrearCliente(cliente);

                if (resultadoCliente)
                {
                    await DisplayAlert("Alerta", "Usuario registrado", "OK");
                }
                else
                {
                    await DisplayAlert("Alerta", "Error al registrar el cliente", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alerta", "Error al registrar la cuenta", "OK");

            }
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - fechaNacimiento.Year;

            // Ajusta la edad si la fecha de cumpleaños aún no ha pasado en el año actual
            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

            return edad;
        }
    }
}
