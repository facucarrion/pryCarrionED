namespace pryCarrionED
{
    partial class frmPrincipal
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
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDoblementeEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarUnaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaVariasOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesEnBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructurasLinealesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilaToolStripMenuItem,
            this.colaToolStripMenuItem,
            this.listaSimpleToolStripMenuItem,
            this.listaDoblementeEnlazadaToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras Lineales";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDoblementeEnlazadaToolStripMenuItem
            // 
            this.listaDoblementeEnlazadaToolStripMenuItem.Name = "listaDoblementeEnlazadaToolStripMenuItem";
            this.listaDoblementeEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.listaDoblementeEnlazadaToolStripMenuItem.Text = "Lista Doblemente Enlazada";
            this.listaDoblementeEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.listaDoblementeEnlazadaToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarUnaTablaToolStripMenuItem,
            this.consultaVariasOperacionesToolStripMenuItem,
            this.operacionesEnBaseDeDatosToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            // 
            // mostrarUnaTablaToolStripMenuItem
            // 
            this.mostrarUnaTablaToolStripMenuItem.Name = "mostrarUnaTablaToolStripMenuItem";
            this.mostrarUnaTablaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.mostrarUnaTablaToolStripMenuItem.Text = "Mostrar una tabla";
            this.mostrarUnaTablaToolStripMenuItem.Click += new System.EventHandler(this.mostrarUnaTablaToolStripMenuItem_Click);
            // 
            // consultaVariasOperacionesToolStripMenuItem
            // 
            this.consultaVariasOperacionesToolStripMenuItem.Name = "consultaVariasOperacionesToolStripMenuItem";
            this.consultaVariasOperacionesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.consultaVariasOperacionesToolStripMenuItem.Text = "Consulta varias operaciones";
            this.consultaVariasOperacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaVariasOperacionesToolStripMenuItem_Click);
            // 
            // operacionesEnBaseDeDatosToolStripMenuItem
            // 
            this.operacionesEnBaseDeDatosToolStripMenuItem.Name = "operacionesEnBaseDeDatosToolStripMenuItem";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.operacionesEnBaseDeDatosToolStripMenuItem.Text = "Operaciones en base de datos";
            this.operacionesEnBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.operacionesEnBaseDeDatosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDoblementeEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarUnaTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaVariasOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesEnBaseDeDatosToolStripMenuItem;
    }
}

