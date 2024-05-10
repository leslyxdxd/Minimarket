namespace ProyVentas_GUI
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            vendedoresToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem1 = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            facturasClienteToolStripMenuItem = new ToolStripMenuItem();
            facturasVendedorToolStripMenuItem = new ToolStripMenuItem();
            listadosToolStripMenuItem = new ToolStripMenuItem();
            listadosXMLToolStripMenuItem = new ToolStripMenuItem();
            listadosExcelToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            generarGuiaToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem, listadosToolStripMenuItem, salirDelSistemasToolStripMenuItem, generarGuiaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1059, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendedoresToolStripMenuItem, productoToolStripMenuItem, proveedoresToolStripMenuItem1 });
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(106, 20);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // vendedoresToolStripMenuItem
            // 
            vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            vendedoresToolStripMenuItem.Size = new Size(180, 22);
            vendedoresToolStripMenuItem.Text = "Vendedores";
            vendedoresToolStripMenuItem.Click += vendedoresToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(180, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem1
            // 
            proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            proveedoresToolStripMenuItem1.Size = new Size(180, 22);
            proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasClienteToolStripMenuItem, facturasVendedorToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(73, 20);
            consultasToolStripMenuItem.Text = "Productos";
            // 
            // facturasClienteToolStripMenuItem
            // 
            facturasClienteToolStripMenuItem.Name = "facturasClienteToolStripMenuItem";
            facturasClienteToolStripMenuItem.Size = new Size(171, 22);
            facturasClienteToolStripMenuItem.Text = "Facturas Cliente";
            facturasClienteToolStripMenuItem.Click += facturasClienteToolStripMenuItem_Click;
            // 
            // facturasVendedorToolStripMenuItem
            // 
            facturasVendedorToolStripMenuItem.Name = "facturasVendedorToolStripMenuItem";
            facturasVendedorToolStripMenuItem.Size = new Size(171, 22);
            facturasVendedorToolStripMenuItem.Text = "Facturas Vendedor";
            // 
            // listadosToolStripMenuItem
            // 
            listadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadosXMLToolStripMenuItem, listadosExcelToolStripMenuItem });
            listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            listadosToolStripMenuItem.Size = new Size(62, 20);
            listadosToolStripMenuItem.Text = "Listados";
            // 
            // listadosXMLToolStripMenuItem
            // 
            listadosXMLToolStripMenuItem.Name = "listadosXMLToolStripMenuItem";
            listadosXMLToolStripMenuItem.Size = new Size(147, 22);
            listadosXMLToolStripMenuItem.Text = "Listados XML";
            listadosXMLToolStripMenuItem.Click += listadosXMLToolStripMenuItem_Click;
            // 
            // listadosExcelToolStripMenuItem
            // 
            listadosExcelToolStripMenuItem.Name = "listadosExcelToolStripMenuItem";
            listadosExcelToolStripMenuItem.Size = new Size(147, 22);
            listadosExcelToolStripMenuItem.Text = "Listados Excel";
            listadosExcelToolStripMenuItem.Click += listadosExcelToolStripMenuItem_Click;
            // 
            // salirDelSistemasToolStripMenuItem
            // 
            salirDelSistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            salirDelSistemasToolStripMenuItem.Name = "salirDelSistemasToolStripMenuItem";
            salirDelSistemasToolStripMenuItem.Size = new Size(104, 20);
            salirDelSistemasToolStripMenuItem.Text = "Salir del Sistema";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1059, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            lbl1.BackColor = SystemColors.ActiveCaptionText;
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 17);
            lbl1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(19, 17);
            lblUsuario.Text = "....";
            // 
            // generarGuiaToolStripMenuItem
            // 
            generarGuiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem });
            generarGuiaToolStripMenuItem.Name = "generarGuiaToolStripMenuItem";
            generarGuiaToolStripMenuItem.Size = new Size(87, 20);
            generarGuiaToolStripMenuItem.Text = "Generar Guia";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 22);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click_1;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1059, 519);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIPrincipal";
            Text = "Inventario Minimarket";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem vendedoresToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem facturasClienteToolStripMenuItem;
        private ToolStripMenuItem facturasVendedorToolStripMenuItem;
        private ToolStripMenuItem listadosToolStripMenuItem;
        private ToolStripMenuItem listadosXMLToolStripMenuItem;
        private ToolStripMenuItem listadosExcelToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem salirDelSistemasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem1;
        private ToolStripMenuItem generarGuiaToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
    }
}