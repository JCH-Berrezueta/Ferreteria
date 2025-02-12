
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




        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            
        }
    }

}
