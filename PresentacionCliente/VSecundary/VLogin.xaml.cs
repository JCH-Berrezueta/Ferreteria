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
            // No permitir navegar hacia atrás
            return true;
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception error)
            {
                await DisplayAlert("Error", "Error al iniciar sesión", "Aceptar");

            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VRegister());
        }
    }
}
