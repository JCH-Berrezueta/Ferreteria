using CapaEntidades.Gestion;
using CapaEntidades.Vistas;
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

namespace PresentacionAdmin
{
    public partial class frmEditProducto : Form
    {
      
        
        public VProductoCategoria auxiliar;

        public frmEditProducto()
        {
            InitializeComponent();
            cargarDatos();
            textBox1.Enabled = true;
        }

        public int buscarIndice(System.Windows.Forms.ComboBox comboBox, string value)
        {
            foreach (object item in comboBox.Items)
            {
                if (item.GetType() == typeof(Categoria))
                {
                    if ((item as Categoria).Nombre.Equals(value))
                    {
                        return comboBox.Items.IndexOf(item);
                    }
                }
            }
            return -1;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void cargarDatos()
        {
            var categorias = CategoriaLN.listarCategoriaLN();
            if (categorias != null && categorias.Count > 0)
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
                    if (ProductoLN.VerificarCodProducto(int.Parse(textBox1.Text)))
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
                || textBox5.Text == "" || comboBox2.SelectedIndex == -1 || textBox7.Text == "")
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
            string est = comboBox2.SelectedItem.ToString();
            string icono = textBox7.Text;
            string desc = textBox8.Text;
            pro = new Producto(id, cate, nom, pre, stock, est, icono, desc);
            return pro;
        }

        internal void setDatos()
        {
            try
            {
                textBox1.Enabled = false;
                textBox1.ReadOnly = true;
                textBox1.Text = auxiliar.Id.ToString();
                comboBox1.SelectedIndex = buscarIndice(comboBox1, auxiliar.Categoria.ToString());
                textBox3.Text = auxiliar.Producto;
                textBox4.Text = auxiliar.Precio.ToString();
                textBox5.Text = auxiliar.Stock.ToString();
                comboBox2.SelectedItem = auxiliar.Estado;
                textBox7.Text = auxiliar.Icono;
                textBox8.Text = auxiliar.Descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Configurar el ComboBox para que no se edite
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Configurar el ComboBox para que no se edite
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
