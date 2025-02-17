using CapaEntidades.Gestion;
using CapaLogica.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionAdmin.Admins
{
    public partial class frmEditaEmpresa: Form
    {
        public Empresa auxiliar;

        public frmEditaEmpresa()
        {
            InitializeComponent();
        }

        private void Nuevo()
        {
            bool claveRepetida = false;

            if (validar())
            {
                if (label1.Text == "Insertar Empresa")
                {
                    if (EmpresaLN.VerificarCodProducto(int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("El código de la empresa ya existe. Por favor, ingrese un código diferente.",
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
        public bool validar()
        {
            bool val = true;

            if (textBox1.Text == "" ||textBox2.Text==""||  textBox3.Text == "" || textBox4.Text == ""
                || textBox5.Text == "" ||textBox6.Text==""|| textBox7.Text == ""||textBox8.Text==""||textBox9.Text=="")
            {
                val = false;
            }

            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public Empresa CreacionOb()
        {
            Empresa pro;
            int id = int.Parse(textBox1.Text);
            string nombre =textBox2.Text;
            string ruc = textBox3.Text;
            string direccion = textBox4.Text;
            string representante = textBox5.Text;
            string telefono = textBox6.Text;
            string mail = textBox7.Text;
            string descripcion = textBox8.Text;
            string observacion = textBox9.Text;
            pro = new Empresa(id, nombre,ruc, direccion, representante, telefono, mail, descripcion, observacion);
            return pro;
        }

        internal void setDatos()
        {
            try
            {
                textBox1.Text = auxiliar.IdEmpresa.ToString();
                textBox2.Text = auxiliar.Ruc;
                textBox3.Text = auxiliar.Nombre;
                textBox4.Text = auxiliar.Direccion;
                textBox5.Text = auxiliar.Representante;
                textBox6.Text = auxiliar.Telefono;
                textBox7.Text = auxiliar.Mail;
                textBox8.Text = auxiliar.Descripcion;
                textBox9.Text = auxiliar.Observacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos");

            }
        }
    }
}
