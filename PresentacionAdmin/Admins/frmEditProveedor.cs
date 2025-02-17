using CapaEntidades.Gestion;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionAdmin.Admins
{
    public partial class frmEditProveedor: Form
    {
        internal Proveedor auxiliar;

        public frmEditProveedor()
        {
            InitializeComponent();
            cargarDatos();
        }

        public int buscarIndice(System.Windows.Forms.ComboBox comboBox, string value)
        {
            foreach (object item in comboBox.Items)
            {
                if (item.GetType() == typeof(Empresa))
                {
                    if ((item as Empresa).Nombre.Equals(value))
                    {
                        return comboBox.Items.IndexOf(item);
                    }
                }
            }
            return -1;

        }

        public void cargarDatos()
        {
            var empresa = EmpresaLN.listarEmpresasLN();
            if (empresa != null && empresa.Count > 0)
            {
                comboBox1.DataSource = empresa;
                comboBox1.DisplayMember = "Nombre";
                comboBox1.ValueMember = "IdEmpresa";
            }
            else
            {
                MessageBox.Show("No hay empresas registradas");
            }
        }
        internal Proveedor CreacionOb()
        {
            Proveedor pro;
            int id = int.Parse(textBox1.Text);
            int emp = int.Parse(comboBox1.SelectedValue.ToString());
            string nom = textBox2.Text;
            string ape = textBox3.Text;
            DateTime fecha =dateTimePicker1.Value;
            int edad = int.Parse(textBox5.Text);
            string mail = textBox6.Text;
            string tel = textBox7.Text;
            string obs = textBox8.Text;
            pro = new Proveedor(id, emp, nom, ape, fecha, edad, mail, tel, obs);
            return pro;
        }

        internal void setDatos()
        {
            textBox1.Text = auxiliar.IdProveedor.ToString();
            comboBox1.SelectedIndex = buscarIndice(comboBox1, auxiliar.IdEmpresa.ToString());
            textBox2.Text = auxiliar.Nombre;
            textBox3.Text = auxiliar.Apellido;
            dateTimePicker1.Text = auxiliar.FechaNacimiento.ToString();
            textBox5.Text = auxiliar.Edad.ToString();
            textBox6.Text = auxiliar.Mail;
            textBox7.Text = auxiliar.Telefono;
            textBox8.Text = auxiliar.Observacion;
        }
        private void Nuevo()
        {
            bool claveRepetida = false;

            if (validar())
            {
                if (label1.Text == "Insertar Proveedor")
                {
                    if (ProveedorLN.VerificarCodProducto(int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("El código del proveedor ya existe. Por favor, ingrese un código diferente.",
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

            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || dateTimePicker1.Text == ""
                || textBox5.Text == "" || textBox2.Text == "" || textBox7.Text == ""|| textBox6.Text==""||textBox8.Text=="")
            {
                val = false;
            }

            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
