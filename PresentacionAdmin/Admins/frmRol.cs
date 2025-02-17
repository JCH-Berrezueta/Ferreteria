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
    public partial class frmRol: Form
    {
        public frmRol()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = RolLN.listarRolsLN();
        }

       

        
    }
}
