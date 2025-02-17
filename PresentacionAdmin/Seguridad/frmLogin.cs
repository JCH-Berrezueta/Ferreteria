using CapaEntidades.Gestion;
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

namespace PresentacionAdmin.Seguridad
{
    public partial class frmLogin: Form
    {
       
        public Cuenta pro=new Cuenta();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Asignar valores de los TextBox a las propiedades del objeto 'pro'
                pro.Mail = textBox1.Text;
                pro.Password = textBox2.Text;

                // Llamar al método Login y mostrar mensajes basados en el resultado
                if (CuentaLN.autenticarCuentaLN(pro))
                {
                    MessageBox.Show("Bienvenido");
                    this.Hide();
                    frmMenu menu = new frmMenu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                // Manejar posibles excepciones y mostrar el mensaje de error
                MessageBox.Show(ex.Message);
            }
        }
    }
}
