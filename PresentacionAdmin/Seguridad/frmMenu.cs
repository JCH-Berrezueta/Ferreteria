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
    }
}
