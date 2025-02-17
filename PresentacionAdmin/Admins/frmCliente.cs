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
    public partial class frmCliente: Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            dataGridView1.DataSource = ClienteLN.listarClientesLN();
        }
    }
}
