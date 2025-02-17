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

namespace PresentacionAdmin.Admins
{
    public partial class frmProveedor: Form
    {
        public frmProveedor()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = ProveedorLN.listarProveedoresLN();
        }

        public void Nuevo()
        {
            frmEditProveedor frm = new frmEditProveedor();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Proveedor op = frm.CreacionOb();
                ProveedorLN.insertarProveedorLN(op);
                frm.Hide();
                Listar();
            }
        }

        private void Modificar()
        {
            try
            {
                Proveedor vop = dataGridView1.CurrentRow.DataBoundItem as Proveedor;
                frmEditProveedor frm = new frmEditProveedor();
                frm.label1.Text = "Modificar Producto";
                frm.auxiliar = vop;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ProveedorLN.modirficarProveedorLN(frm.CreacionOb());
                    frm.Hide();
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("Desea eliminar proveedor", "Eliminar Proveedor", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Proveedor obp = dataGridView1.CurrentRow.DataBoundItem as Proveedor;
                        Proveedor op = new Proveedor(obp.IdProveedor);
                        ProductoLN.EliminarProducto(op.IdProveedor);
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
