using CapaEntidades.Gestion;
using CapaEntidades.Vistas;
using CapaLogica.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin
{
    public partial class frmCategoriaProducto : Form
    {
        public frmCategoriaProducto()
        {
            InitializeComponent();
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        public void Listar()
        {
            dataGridView1.DataSource = CategoriaLN.listarCategoriaLN();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            frmEditCategoria frm = new frmEditCategoria();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Categoria op = frm.CreacionOb();
                CategoriaLN.insertarCategoriaLN(op);
                frm.Hide();
                Listar();
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            try
            {
                Categoria vop = dataGridView1.CurrentRow.DataBoundItem as Categoria;
                frmEditCategoria frm = new frmEditCategoria();
                frm.label1.Text = "Modificar Producto";
                frm.auxiliar = vop;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    CategoriaLN.modificarCategoriaLN(frm.CreacionOb());
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
                        Categoria obp = dataGridView1.CurrentRow.DataBoundItem as Categoria;
                        Categoria op = new Categoria(obp.IdCategoria);
                        CategoriaLN.eliminarCategoriaLN(op.IdCategoria);
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
