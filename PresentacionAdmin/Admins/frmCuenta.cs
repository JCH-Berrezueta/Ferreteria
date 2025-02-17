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
    }
}
