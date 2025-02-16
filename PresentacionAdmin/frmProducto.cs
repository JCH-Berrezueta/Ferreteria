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
using CapaEntidades.Vistas;
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
        private void frmProducto_Load(object sender, EventArgs e)
        {
            Listar();
            //listarProductos("");

        }

  
        public void listarProductos(string valor)
        {
            dataGridView1.DataSource =ProductoLN.listarVistaProductosLN();
        }
        public void Listar()
        {
            dataGridView1.DataSource = ProductoLN.listarVistaProductosLN();
        }
        public void Nuevo()
        {
            frmEditProducto frm = new frmEditProducto();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Producto op = frm.CreacionOb();
                oln.InsertarProducto(op);
                frm.Hide();
                Listar();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            try
            {
                VProductoCategoria vop = dataGridView1.CurrentRow.DataBoundItem as VProductoCategoria;
                frmEditProducto frm = new frmEditProducto();
                frm.label1.Text = "Modificar Producto";
                frm.auxiliar = vop;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    oln.ActualizarProducto(frm.CreacionOb());
                    frm.Hide();
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("Desea eliminar Producto", "Eliminar Producto", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        VProductoCategoria obp = dataGridView1.CurrentRow.DataBoundItem as VProductoCategoria;
                        VProductoCategoria op = new VProductoCategoria(obp.Id);
                        oln.EliminarProducto(op.Id);
                        Listar();
                    }

                }
                else
                    MessageBox.Show("Seleccione la fila");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error al eliminar datos" + ex.Message);
            }
        }
    }

    
}
