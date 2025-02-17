using CapaLogica.Seguridad;
using PresentacionCliente.Services;
using PresentacionCliente.VSecundary.VThird;
using System.Diagnostics;
using System.Threading.Tasks;
using cuesa = CapaEntidades.Gestion.Cuenta;

namespace PresentacionCliente.VSecundary
{
    public partial class VLogin : ContentPage
    {
        private readonly PresentacionCliente.Services.Cuenta _httpCuenta;

        public VLogin()
        {
            InitializeComponent();
            var httpCuenta = new HttpClient();
            _httpCuenta = new PresentacionCliente.Services.Cuenta(httpCuenta);
        }

        protected override bool OnBackButtonPressed()
        {
            // No permitir navegar hacia atrás
            return true;
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CorreoU.Text) || string.IsNullOrEmpty(ContraU.Text))
                {
                    await DisplayAlert("Error", "Debe completar los campos", "Aceptar");
                    return;
                }

                // Crear un objeto cuenta con los datos ingresados
                var cuenta = new cuesa
                {
                    IdRol = 1,
                    Mail = CorreoU.Text,
                    Password = ContraU.Text
                };

                // Autenticar la cuenta
                bool credencialesCorrectas = await _httpCuenta.AutenticarCuenta(cuenta);
                Debug.WriteLine(credencialesCorrectas);
                if (credencialesCorrectas)
                {
                    await Navigation.PushAsync(new VProductos());
                }
                else
                {
                    await DisplayAlert("Error", "Correo electrónico o contraseña incorrectos", "Aceptar");
                }
            }
            catch (Exception error)
            {
                await DisplayAlert("Error", "Error al iniciar sesión: " + error.Message, "Aceptar");
                Debug.WriteLine("Error al iniciar sesión: " + error);
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VRegister());
        }
    }
}
