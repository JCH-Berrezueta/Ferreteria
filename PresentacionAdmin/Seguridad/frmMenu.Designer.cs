namespace PresentacionAdmin.Seguridad
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorClienteToolStripMenuItem,
            this.administradorCuentaToolStripMenuItem,
            this.administradorProductoToolStripMenuItem,
            this.administradorProveedorToolStripMenuItem,
            this.administradorRolToolStripMenuItem,
            this.administradorEmpresaToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // administradorClienteToolStripMenuItem
            // 
            this.administradorClienteToolStripMenuItem.Name = "administradorClienteToolStripMenuItem";
            this.administradorClienteToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.administradorClienteToolStripMenuItem.Text = "Administrador Cliente";
            this.administradorClienteToolStripMenuItem.Click += new System.EventHandler(this.administradorClienteToolStripMenuItem_Click);
            // 
            // administradorCuentaToolStripMenuItem
            // 
            this.administradorCuentaToolStripMenuItem.Name = "administradorCuentaToolStripMenuItem";
            this.administradorCuentaToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.administradorCuentaToolStripMenuItem.Text = "Administrador Cuenta";
            this.administradorCuentaToolStripMenuItem.Click += new System.EventHandler(this.administradorCuentaToolStripMenuItem_Click);
            // 
            // administradorProductoToolStripMenuItem
            // 
            this.administradorProductoToolStripMenuItem.Name = "administradorProductoToolStripMenuItem";
            this.administradorProductoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.administradorProductoToolStripMenuItem.Text = "Administrador Producto";
            this.administradorProductoToolStripMenuItem.Click += new System.EventHandler(this.administradorProductoToolStripMenuItem_Click);
            // 
            // administradorProveedorToolStripMenuItem
            // 
            this.administradorProveedorToolStripMenuItem.Name = "administradorProveedorToolStripMenuItem";
            this.administradorProveedorToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.administradorProveedorToolStripMenuItem.Text = "Administrador Proveedor";
            this.administradorProveedorToolStripMenuItem.Click += new System.EventHandler(this.administradorProveedorToolStripMenuItem_Click);
            // 
            // administradorRolToolStripMenuItem
            // 
            this.administradorRolToolStripMenuItem.Name = "administradorRolToolStripMenuItem";
            this.administradorRolToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.administradorRolToolStripMenuItem.Text = "Administrador Rol";
            this.administradorRolToolStripMenuItem.Click += new System.EventHandler(this.administradorRolToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // administradorEmpresaToolStripMenuItem
            // 
            this.administradorEmpresaToolStripMenuItem.Name = "administradorEmpresaToolStripMenuItem";
            this.administradorEmpresaToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.administradorEmpresaToolStripMenuItem.Text = "Administrador Empresa";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorEmpresaToolStripMenuItem;
    }
}