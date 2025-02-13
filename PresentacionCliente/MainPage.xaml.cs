
using PresentacionCliente.Services;
using System.Diagnostics;
using EntidadProducto = CapaEntidades.Gestion.Producto;


namespace PresentacionCliente
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private Producto servicio;

        public MainPage()
        {
            InitializeComponent();
            servicio = new Producto();
            intentar();
        }

        public async void intentar()
        {
            List<EntidadProducto> lista =  await servicio.ObtenerProductos();
            Debug.WriteLine("RESULTADO" + lista[0].Descripcion);
        }

        private async void BotonIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VSecundary.VLogin());

        }



    }

}
