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
using CapaLogica.Seguridad;


namespace PresentacionAdmin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string correo = textBox2.Text.Trim();

            if (CuentaLN.ValidarUsuario(usuario, correo))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmProducto frm = new frmProducto();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o correo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
