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

namespace PresentacionAdmin
{
    public partial class frmEditProducto : Form
    {
        ProductoLN oln = new ProductoLN();
        CategoriaLN categoria = new CategoriaLN();
        public frmEditProducto()
        {
            InitializeComponent();
            cargarDatos();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void cargarDatos()
        {
            var categorias = categoria.listarCategoriaLN();
            if(categorias != null && categorias.Count>0)
            {
                comboBox1.DataSource = categorias;
                comboBox1.DisplayMember = "Nombre";
                comboBox1.ValueMember = "IdCategoria";
            }
            else
            {
                MessageBox.Show("No hay categorias registradas");
            }
        }
        private void Nuevo()
        {
            bool claveRepetida = false;

            if (validar())
            {
                if (label1.Text == "Insertar Producto")
                {
                    if (oln.VerificarCodProducto(int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("El código del producto ya existe. Por favor, ingrese un código diferente.",
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

            if (textBox1.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || textBox4.Text == ""
                || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" )
            {
                val = false;
            }

            return val;
        }

        public Producto CreacionOb()
        {
            Producto pro;
            int id = int.Parse(textBox1.Text);
            int cate = int.Parse(comboBox1.SelectedValue.ToString());
            string nom = textBox3.Text;
            decimal pre = decimal.Parse(textBox4.Text);
            int stock = int.Parse(textBox5.Text);
            string est = textBox6.Text;
            string icono = textBox7.Text;
            string desc = textBox8.Text;
            pro = new Producto(id, cate, nom, pre, stock, est, icono, desc);
            return pro;
        }
    }
}
