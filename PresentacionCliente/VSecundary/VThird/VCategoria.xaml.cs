using CapaEntidades.Gestion;
using categoria= CapaEntidades.Gestion.Categoria;
using ServicioCategoria = PresentacionCliente.Services.Categoria;
namespace PresentacionCliente.VSecundary.VThird;

public partial class VCategoria : ContentPage
{
	private readonly ServicioCategoria _servicioCategoria;
    public VCategoria()
	{
		InitializeComponent();
        _servicioCategoria = new ServicioCategoria();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadDataAsync();
    }
    private async Task LoadDataAsync()
    {
        var productos = await getVistaCategoria().ConfigureAwait(false);
        // Ensure UI updates are done on the main thread.
        MainThread.BeginInvokeOnMainThread(() =>
        {
            CategoriesListView.ItemsSource = productos;
        });

    }

    public async Task<List<categoria>> getVistaCategoria()
    {
        List<categoria> productos = await _servicioCategoria.listarVistaCliente().ConfigureAwait(false);
        return productos;
    }
}