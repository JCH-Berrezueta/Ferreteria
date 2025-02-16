using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin.Security
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
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

        private void administradorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmProducto"] == null)
            {
                frmProducto fc = new frmProducto
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }
    }
}
