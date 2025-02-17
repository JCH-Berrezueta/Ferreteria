using CapaLogica.Seguridad;
using PresentacionCliente.Services;
using PresentacionCliente.VSecundary.VThird;
using System.Diagnostics;
using System.Threading.Tasks;
using cuesa= CapaEntidades.Gestion.Cuenta;
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
            // No permitir navegar hacia atr�s
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

                // Obtener la lista de correos electr�nicos y contrase�as
                var correosContrase�as = await _httpCuenta.ListarCorreosContrase�as();

                // Verificar si las credenciales ingresadas coinciden con alguna en la lista
                bool credencialesCorrectas = correosContrase�as.Any(c => c.Mail == CorreoU.Text && c.Password == ContraU.Text);

                if (credencialesCorrectas)
                {
                    await Navigation.PushAsync(new VProductos());
                }
                else
                {
                    await DisplayAlert("Error", "Correo electr�nico o contrase�a incorrectos", "Aceptar");
                }
            }
            catch (Exception error)
            {
                await DisplayAlert("Error", "Error al iniciar sesi�n", "Aceptar");
                }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VRegister());
        }
    }
}
