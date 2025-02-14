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
        ProductoLN oln = new ProductoLN();
        public frmProducto()
        {
            InitializeComponent();
          
           
        }
        ProductoLN pd = new ProductoLN();
        private void frmProducto_Load(object sender, EventArgs e)
        {
            

        }
        public void ListarProductos(string alv)
        {
            dataGridView1.DataSource = ProductoLN.listarProductosLN();
        }
        public void Nuevo()
        {
            frmEditProducto frm = new frmEditProducto();
            
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Producto op = frm.CrearObjeto();
                oln.CreateProducto(op);
                frm.Hide();
                ListarProductos("");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmEditProducto frm = new frmEditProducto();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                Producto op = frm.CreacionOb();
                oln.InsertarProducto(op);
                frm.Hide();
                ProductoLN.listarProductosLN();

            }
=======
           
>>>>>>> productoln
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }

    
}
