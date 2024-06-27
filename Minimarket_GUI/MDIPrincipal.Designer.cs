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
            consultasToolStripMenuItem = new ToolStripMenuItem();
            StokTienda = new ToolStripMenuItem();
            stokAlmacen = new ToolStripMenuItem();
            generarGuiaToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            gestionarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            gestionarVentaToolStripMenuItem = new ToolStripMenuItem();
            boletaToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            generarRemisionToolStripMenuItem = new ToolStripMenuItem();
            comprobantesToolStripMenuItem = new ToolStripMenuItem();
            boletasToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultasToolStripMenuItem, generarGuiaToolStripMenuItem, gestionarUsuariosToolStripMenuItem, gestionarVentaToolStripMenuItem, generarRemisionToolStripMenuItem, comprobantesToolStripMenuItem, salirDelSistemasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 11, 10, 11);
            menuStrip1.Size = new Size(1124, 46);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StokTienda, stokAlmacen });
            consultasToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(87, 24);
            consultasToolStripMenuItem.Text = "Productos";
            // 
            // StokTienda
            // 
            StokTienda.Name = "StokTienda";
            StokTienda.Size = new Size(180, 24);
            StokTienda.Text = "Stock ";
            StokTienda.Click += facturasClienteToolStripMenuItem_Click;
            // 
            // stokAlmacen
            // 
            stokAlmacen.Name = "stokAlmacen";
            stokAlmacen.Size = new Size(180, 24);
            stokAlmacen.Text = "Stock";
            stokAlmacen.Click += stokAlmacen_Click;
            // 
            // generarGuiaToolStripMenuItem
            // 
            generarGuiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem });
            generarGuiaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generarGuiaToolStripMenuItem.Name = "generarGuiaToolStripMenuItem";
            generarGuiaToolStripMenuItem.Size = new Size(103, 24);
            generarGuiaToolStripMenuItem.Text = "Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 24);
            proveedoresToolStripMenuItem.Text = "Lista Proveedor";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click_1;
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            gestionarUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, agregarUsuarioToolStripMenuItem });
            gestionarUsuariosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.Size = new Size(144, 24);
            gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            gestionarUsuariosToolStripMenuItem.Click += gestionarUsuariosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(186, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(186, 24);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            agregarUsuarioToolStripMenuItem.Click += agregarUsuarioToolStripMenuItem_Click;
            // 
            // gestionarVentaToolStripMenuItem
            // 
            gestionarVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boletaToolStripMenuItem, facturaToolStripMenuItem });
            gestionarVentaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestionarVentaToolStripMenuItem.Name = "gestionarVentaToolStripMenuItem";
            gestionarVentaToolStripMenuItem.Size = new Size(125, 24);
            gestionarVentaToolStripMenuItem.Text = "Gestionar Venta";
            gestionarVentaToolStripMenuItem.Click += gestionarVentaToolStripMenuItem_Click;
            // 
            // boletaToolStripMenuItem
            // 
            boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
            boletaToolStripMenuItem.Size = new Size(125, 24);
            boletaToolStripMenuItem.Text = "Boleta";
            boletaToolStripMenuItem.Click += boletaToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(125, 24);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // generarRemisionToolStripMenuItem
            // 
            generarRemisionToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generarRemisionToolStripMenuItem.Name = "generarRemisionToolStripMenuItem";
            generarRemisionToolStripMenuItem.Size = new Size(143, 24);
            generarRemisionToolStripMenuItem.Text = "Guias de Remision";
            generarRemisionToolStripMenuItem.Click += generarRemisionToolStripMenuItem_Click;
            // 
            // comprobantesToolStripMenuItem
            // 
            comprobantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boletasToolStripMenuItem, facturasToolStripMenuItem });
            comprobantesToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            comprobantesToolStripMenuItem.Size = new Size(119, 24);
            comprobantesToolStripMenuItem.Text = "Comprobantes";
            // 
            // boletasToolStripMenuItem
            // 
            boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            boletasToolStripMenuItem.Size = new Size(131, 24);
            boletasToolStripMenuItem.Text = "Boletas";
            boletasToolStripMenuItem.Click += boletasToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(131, 24);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // salirDelSistemasToolStripMenuItem
            // 
            salirDelSistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            salirDelSistemasToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirDelSistemasToolStripMenuItem.Name = "salirDelSistemasToolStripMenuItem";
            salirDelSistemasToolStripMenuItem.Size = new Size(50, 24);
            salirDelSistemasToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(107, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(0, 553);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1124, 35);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.DimGray;
            lbl1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(91, 30);
            lbl1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.Highlight;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(37, 30);
            lblUsuario.Text = "....";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1124, 588);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INVENTARIO MINIMARKET";
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
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem StokTienda;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem salirDelSistemasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem generarGuiaToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private ToolStripMenuItem gestionarVentaToolStripMenuItem;
        private ToolStripMenuItem generarRemisionToolStripMenuItem;
        private ToolStripMenuItem stokAlmacen;
        private ToolStripMenuItem boletaToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem comprobantesToolStripMenuItem;
        private ToolStripMenuItem boletasToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
    }
}