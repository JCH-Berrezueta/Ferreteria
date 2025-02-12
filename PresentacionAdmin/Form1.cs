using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(CapaLogica.Gestion.ProductoLN.listarProductosLN()[0].Descripcion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
