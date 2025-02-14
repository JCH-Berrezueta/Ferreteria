using System.ComponentModel;
using Producto = CapaEntidades.Vistas.VProductoCategoria;
using ServicioProducto = PresentacionCliente.Services.Producto;

namespace PresentacionCliente.VSecundary.VThird;

public partial class VProductos : ContentPage
{
	public VProductos()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

	public async Task<List<Producto>> getVistaProductos()
	{
		List<Producto> productos = await ServicioProducto.listarVistaProductos();
		return productos;
	}
}