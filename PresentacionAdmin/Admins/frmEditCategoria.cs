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

namespace PresentacionAdmin
{
    public partial class frmEditCategoria : Form
    {
        public Categoria auxiliar;

        public frmEditCategoria()
        {
            InitializeComponent();
        }

        public Categoria CreacionOb()
        {
            Categoria cat;
            int id = int.Parse(textBox1.Text);
            string nom = textBox2.Text;
            string desc = textBox3.Text;
            cat = new Categoria(id, nom, desc);
            return cat;
        }

        internal void setDatos()
        {
            textBox1.Text = auxiliar.IdCategoria.ToString();
            textBox2.Text = auxiliar.Nombre;
            textBox3.Text = auxiliar.Descripcion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool claveRepetida = false;

            if (validar())
            {
                if (label1.Text == "Insertar Producto")
                {
                    if (CategoriaLN.VerificarCodProducto(int.Parse(textBox1.Text)))
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
        private bool validar()
        {
            bool val = true;
            if (textBox1.Text == "" || textBox3.Text == "" || textBox3.Text == "")
            {
                val = false;
            }

            return val;
        }
    }
}
