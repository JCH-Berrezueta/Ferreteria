using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Gestion;
using CapaLogica.Gestion;
namespace PresentacionAdmin
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductoLN.listarProductosLN();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto
            {
                Id_CategoriaProducto = 1, // Debes asignar la categoría correspondiente
                Nombre = "Nuevo Producto",
                Precio = 10.0m,
                Stock = 100,
                Estado = true,
                Icono = null, // Puedes asignar una imagen si es necesario
                Descripcion = "Descripción del producto"
            };

            if (ProductoLN.listarProductosLN(nuevoProducto))
            {
                MessageBox.Show("Producto agregado correctamente");
                CargarProductos();
            }
            else
            {
                MessageBox.Show("Error al agregar producto");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
