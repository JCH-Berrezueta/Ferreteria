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
    public partial class frmCuenta: Form
    {
        public frmCuenta()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = CuentaLN.listarCuentasLN();
        }

        private void Nuevo()
        {
            frmEditCuenta frm = new frmEditCuenta();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Cuenta op = frm.CreacionOb();
                CuentaLN.insertarCuentaLN(op);
                frm.Hide();
                Listar();
            }
        }


        private void Modificar()
        {
            try
            {
                Cuenta vop = dataGridView1.CurrentRow.DataBoundItem as Cuenta;
                frmEditCuenta frm = new frmEditCuenta();
                frm.label1.Text = "Modificar Cuenta";
                frm.auxiliar = vop;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    CuentaLN.modificarCuentaLN(frm.CreacionOb());
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
                    var res = MessageBox.Show("Desea eliminar Cuenta", "Eliminar Cuenta", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Cuenta obp = dataGridView1.CurrentRow.DataBoundItem as Cuenta;
                        Cuenta op = new Cuenta(obp.IdCuenta);
                        CuentaLN.eliminarCuentaLN(op.IdCuenta);
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
