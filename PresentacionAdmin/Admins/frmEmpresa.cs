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
    public partial class frmEmpresa: Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = EmpresaLN.listarEmpresasLN();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            frmEditaEmpresa frm = new frmEditaEmpresa();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Empresa op = frm.CreacionOb();
                EmpresaLN.insertarEmpresaLN(op);
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
                Empresa vop = dataGridView1.CurrentRow.DataBoundItem as Empresa;
                frmEditaEmpresa frm = new frmEditaEmpresa();
                frm.label1.Text = "Modificar Producto";
                frm.auxiliar = vop;
                frm.setDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    EmpresaLN.modificarEmpresaLN(frm.CreacionOb());
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
                    var res = MessageBox.Show("Desea eliminar Empresa", "Eliminar Empresa", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Empresa obp = dataGridView1.CurrentRow.DataBoundItem as Empresa;
                        Empresa op = new Empresa(obp.IdEmpresa);
                        EmpresaLN.eliminarEmpresaLN(op.IdEmpresa);
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
