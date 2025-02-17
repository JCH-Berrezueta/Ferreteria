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
    public partial class frmEditCliente: Form
    {
        internal Cliente auxiliar;

        public frmEditCliente()
        {
            InitializeComponent();
        }

        public Cliente CreacionOb()
        {
            Cliente cli;
            int id = int.Parse(textBox1.Text);
            int idcu = int.Parse(textBox2.Text);
            string nom = textBox3.Text;
            string ape = textBox4.Text;
            DateTime fecha = dateTimePicker1.Value;
            int edad = CalcularEdad(fecha);
            string tele = textBox7.Text;
            cli = new Cliente(id, idcu, nom, ape, fecha, edad, tele);
            return cli;
        }

        public void setDatos()
        {
           textBox1.Text = auxiliar.IdCliente.ToString();
            textBox2.Text = auxiliar.IdCuenta.ToString();
            textBox3.Text = auxiliar.Nombre;
            textBox4.Text = auxiliar.Apellido;
            dateTimePicker1.Value = auxiliar.FechaNacimiento;  
            textBox6.Text = auxiliar.Edad.ToString();
            textBox7.Text = auxiliar.Telefono;
        }

        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Si la fecha de nacimiento es posterior a la fecha actual, resta un año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        private bool validar()
        {
            bool val = true;
            if (textBox1.Text == "" || textBox3.Text == "" || textBox3.Text == "" || textBox4.Text == ""||textBox6.Text==""||textBox7.Text==""||dateTimePicker1.Text=="")
            {
                val = false;
            }

            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool claveRepetida = false;

            if (validar())
            {
                if (label1.Text == "Insertar Cliente")
                {
                    if (ClienteLN.VerificarCodProducto(int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("El código del cliente ya existe. Por favor, ingrese un código diferente.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        claveRepetida = true;
                    }
                }
                if (!claveRepetida)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
