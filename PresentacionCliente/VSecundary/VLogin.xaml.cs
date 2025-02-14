using System.Threading.Tasks;
using cuentita=CapaEntidades.Gestion.Cuenta;
namespace PresentacionCliente.VSecundary;

public partial class VLogin : ContentPage
{

	public VLogin()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        // No permitir navegar hacia atrás
        return true;

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VThird.VProductos());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VSecundary.VRegister());
    }
}