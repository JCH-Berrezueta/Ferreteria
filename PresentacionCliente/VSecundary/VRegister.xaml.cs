using System.Threading.Tasks;

namespace PresentacionCliente.VSecundary;

public partial class VRegister : ContentPage
{
	public VRegister()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        // No permitir navegar hacia atrás
        return true;

    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", "Usuario registrado", "OK");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", "Cambios cancelados", "OK");
        await Navigation.PopAsync();
    }
}