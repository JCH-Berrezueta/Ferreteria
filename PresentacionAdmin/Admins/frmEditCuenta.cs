﻿using CapaEntidades.Gestion;
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
    public partial class frmEditCuenta: Form
    {
        public Cuenta auxiliar;

        public frmEditCuenta()
        {
            InitializeComponent();
        }

        public Cuenta CreacionOb()
        {
            Cuenta cat;
            int id = int.Parse(textBox1.Text);
            int rol = int.Parse(textBox2.Text);
            string mail = textBox3.Text;
            string pss = textBox4.Text;
            cat = new Cuenta(id, rol, mail, pss);
            return cat;
        }

        internal void setDatos()
        {
            textBox1.Text = auxiliar.IdCuenta.ToString();
            textBox2.Text = auxiliar.IdRol.ToString();
            textBox3.Text = auxiliar.Mail;
            textBox4.Text = auxiliar.Password;
        }

        private bool validar()
        {
            bool val = true;
            if (textBox1.Text == "" || textBox3.Text == "" || textBox3.Text == ""||textBox4.Text=="")
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
                if (label1.Text == "Insertar Cuenta")
                {
                    if (CuentaLN.VerificarCodProducto(int.Parse(textBox1.Text)))
                    {
                        MessageBox.Show("El código de la cuenta ya existe. Por favor, ingrese un código diferente.",
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
