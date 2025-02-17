using CapaEntidades.Gestion;
using CapaLogica.Gestion;
using CapaLogica.Seguridad;
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
    public partial class frmCliente: Form
    {
        public frmCliente()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = ClienteLN.listarClientesLN();
        }

        private void Nuevo()
        {
            frmEditCliente frm = new frmEditCliente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Cliente op = frm.CreacionOb();
                ClienteLN.insertarClienteLN(op);
                frm.Hide();
                Listar();
            }
        }

        private void Modificar()
        {
            try
            {
                Cliente vop = dataGridView1.CurrentRow.DataBoundItem as Cliente;
                frmEditCliente frm = new frmEditCliente();
                frm.label1.Text = "Modificar Cuenta";
                frm.auxiliar = vop;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ClienteLN.modificarCliente(frm.CreacionOb());
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
                    var res = MessageBox.Show("Desea eliminar Cliente", "Eliminar CLiente", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Cliente obp = dataGridView1.CurrentRow.DataBoundItem as Cliente;
                        Cliente op = new Cliente(obp.IdCuenta);
                        ClienteLN.eliminarCliente(op.IdCuenta);
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
