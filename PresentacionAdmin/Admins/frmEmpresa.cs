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
    }
}
