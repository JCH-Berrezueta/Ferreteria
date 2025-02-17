using PresentacionAdmin.Admins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin.Seguridad
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void administradorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminProducto"] == null)
            {
                frmProducto fc = new frmProducto
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administradorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminCliente"] == null)
            {
                Admins.frmCliente fc = new Admins.frmCliente
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administradorCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminCuenta"] == null)
            {
                Admins.frmCuenta fc = new Admins.frmCuenta
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administradorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminProveedor"] == null)
            {
                Admins.frmProveedor fc = new Admins.frmProveedor
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administradorRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminRol"] == null)
            {
                Admins.frmRol fc = new Admins.frmRol
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administradorCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminCategoria"] == null)
            {
                frmCategoriaProducto fc = new frmCategoriaProducto
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }

        private void administradorEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminEmpresa"] == null)
            {
                frmEmpresa fc = new frmEmpresa
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }
    }
}
