using System.ComponentModel;
using System.Threading.Tasks;
using Producto = CapaEntidades.Vistas.VProductoCategoria;
using ServicioProducto = PresentacionCliente.Services.Producto;

namespace PresentacionCliente.VSecundary.VThird
{
    public partial class VProductos : ContentPage
    {
        private readonly ServicioProducto _servicioProducto;

        public VProductos()
        {
            InitializeComponent();
            _servicioProducto = new ServicioProducto();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var productos = await getVistaProductos().ConfigureAwait(false);
            // Ensure UI updates are done on the main thread.
            MainThread.BeginInvokeOnMainThread(() =>
            {
                ProductsCollectionView.ItemsSource = productos;
            });
        }

        public async Task<List<Producto>> getVistaProductos()
        {
            List<Producto> productos = await _servicioProducto.listarVistaProductos().ConfigureAwait(false);
            return productos;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Warning", "Estamos aqui pero no compramos", "OK");
        }
    }
}
