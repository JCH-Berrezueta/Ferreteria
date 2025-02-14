using System.ComponentModel;
using System.Threading.Tasks;
using Producto = CapaEntidades.Vistas.VProductoCategoria;
using ServicioProducto = PresentacionCliente.Services.Producto;

namespace PresentacionCliente.VSecundary.VThird;

public partial class VProductos : ContentPage
{
    public VProductos()
    {
        InitializeComponent();
        // Asynchronously load data after initialization.
        Task.Run(async () => await LoadDataAsync());
    }

    private async Task LoadDataAsync()
    {
        var productos = await getVistaProductos();
        // Ensure UI updates are done on the main thread.
        MainThread.BeginInvokeOnMainThread(() =>
        {
            ProductsCollectionView.ItemsSource = productos;
        });
    }

    public async Task<List<Producto>> getVistaProductos()
    {
        ServicioProducto servicioProducto = new ServicioProducto();
        List<Producto> productos = await servicioProducto.listarVistaProductos();
        return productos;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await DisplayAlert("Warning", "Estamos aqui pero no compramos", "OK");
    } 
}
