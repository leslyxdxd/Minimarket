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
            logoToolStripMenuItem = new ToolStripMenuItem();
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoToolStripMenuItem, consultasToolStripMenuItem, generarGuiaToolStripMenuItem, gestionarUsuariosToolStripMenuItem, gestionarVentaToolStripMenuItem, generarRemisionToolStripMenuItem, comprobantesToolStripMenuItem, salirDelSistemasToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(200, 588);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // logoToolStripMenuItem
            // 
            logoToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            logoToolStripMenuItem.BackgroundImage = Minimarket_GUI.Properties.Resources._608c596cb1fe4297b368b0f0f0a42dd2__1_;
            logoToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            logoToolStripMenuItem.Enabled = false;
            logoToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoToolStripMenuItem.ForeColor = Color.DarkOrange;
            logoToolStripMenuItem.Name = "logoToolStripMenuItem";
            logoToolStripMenuItem.Padding = new Padding(4, 0, 4, 100);
            logoToolStripMenuItem.Size = new Size(199, 122);
            logoToolStripMenuItem.Text = "FRESH SUPERMARKET";
            logoToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StokTienda, stokAlmacen });
            consultasToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.paquete_o_empaquetar;
            consultasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            consultasToolStripMenuItem.Margin = new Padding(0, 10, -3, 0);
            consultasToolStripMenuItem.MergeIndex = 50;
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            consultasToolStripMenuItem.Size = new Size(202, 49);
            consultasToolStripMenuItem.Text = "Productos";
            // 
            // StokTienda
            // 
            StokTienda.Image = Minimarket_GUI.Properties.Resources.monitor;
            StokTienda.Margin = new Padding(0, 10, 0, 0);
            StokTienda.Name = "StokTienda";
            StokTienda.Padding = new Padding(0, 5, 0, 10);
            StokTienda.Size = new Size(180, 37);
            StokTienda.Text = "Stock ";
            StokTienda.Click += facturasClienteToolStripMenuItem_Click;
            // 
            // stokAlmacen
            // 
            stokAlmacen.Image = Minimarket_GUI.Properties.Resources.almacen;
            stokAlmacen.Margin = new Padding(0, 10, 0, 0);
            stokAlmacen.Name = "stokAlmacen";
            stokAlmacen.Padding = new Padding(0, 5, 0, 10);
            stokAlmacen.Size = new Size(180, 37);
            stokAlmacen.Text = "Stock";
            stokAlmacen.Click += stokAlmacen_Click;
            // 
            // generarGuiaToolStripMenuItem
            // 
            generarGuiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem });
            generarGuiaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generarGuiaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.mensajero;
            generarGuiaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            generarGuiaToolStripMenuItem.Margin = new Padding(0, 5, -3, 0);
            generarGuiaToolStripMenuItem.MergeIndex = 50;
            generarGuiaToolStripMenuItem.Name = "generarGuiaToolStripMenuItem";
            generarGuiaToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            generarGuiaToolStripMenuItem.Size = new Size(202, 49);
            generarGuiaToolStripMenuItem.Text = "Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cliente;
            proveedoresToolStripMenuItem.Margin = new Padding(0, 25, 0, 20);
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Padding = new Padding(0, 15, 0, 5);
            proveedoresToolStripMenuItem.Size = new Size(180, 42);
            proveedoresToolStripMenuItem.Text = "Lista Proveedor";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click_1;
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            gestionarUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, agregarUsuarioToolStripMenuItem });
            gestionarUsuariosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestionarUsuariosToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.agregar_usuario;
            gestionarUsuariosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            gestionarUsuariosToolStripMenuItem.Margin = new Padding(0, 5, -3, 0);
            gestionarUsuariosToolStripMenuItem.MergeIndex = 50;
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            gestionarUsuariosToolStripMenuItem.Size = new Size(202, 49);
            gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            gestionarUsuariosToolStripMenuItem.Click += gestionarUsuariosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.agregar;
            usuariosToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Padding = new Padding(0, 10, 0, 10);
            usuariosToolStripMenuItem.Size = new Size(186, 42);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.nuevo;
            agregarUsuarioToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Padding = new Padding(0, 10, 0, 10);
            agregarUsuarioToolStripMenuItem.Size = new Size(186, 42);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            agregarUsuarioToolStripMenuItem.Click += agregarUsuarioToolStripMenuItem_Click;
            // 
            // gestionarVentaToolStripMenuItem
            // 
            gestionarVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boletaToolStripMenuItem, facturaToolStripMenuItem });
            gestionarVentaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestionarVentaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.punto_de_venta;
            gestionarVentaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            gestionarVentaToolStripMenuItem.Margin = new Padding(0, 15, -3, 0);
            gestionarVentaToolStripMenuItem.MergeIndex = 50;
            gestionarVentaToolStripMenuItem.Name = "gestionarVentaToolStripMenuItem";
            gestionarVentaToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            gestionarVentaToolStripMenuItem.Size = new Size(202, 49);
            gestionarVentaToolStripMenuItem.Text = "Gestionar Venta";
            gestionarVentaToolStripMenuItem.Click += gestionarVentaToolStripMenuItem_Click;
            // 
            // boletaToolStripMenuItem
            // 
            boletaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.proyecto_de_ley;
            boletaToolStripMenuItem.Margin = new Padding(0, 10, 0, 0);
            boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
            boletaToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            boletaToolStripMenuItem.Size = new Size(180, 37);
            boletaToolStripMenuItem.Text = "Boleta";
            boletaToolStripMenuItem.Click += boletaToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cuenta;
            facturaToolStripMenuItem.Margin = new Padding(0, 10, 0, 0);
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            facturaToolStripMenuItem.Size = new Size(180, 37);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // generarRemisionToolStripMenuItem
            // 
            generarRemisionToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generarRemisionToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.contrato;
            generarRemisionToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            generarRemisionToolStripMenuItem.Margin = new Padding(0, 5, -3, 0);
            generarRemisionToolStripMenuItem.MergeIndex = 50;
            generarRemisionToolStripMenuItem.Name = "generarRemisionToolStripMenuItem";
            generarRemisionToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            generarRemisionToolStripMenuItem.Size = new Size(202, 49);
            generarRemisionToolStripMenuItem.Text = "Guias de Remision";
            generarRemisionToolStripMenuItem.Click += generarRemisionToolStripMenuItem_Click;
            // 
            // comprobantesToolStripMenuItem
            // 
            comprobantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boletasToolStripMenuItem, facturasToolStripMenuItem });
            comprobantesToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comprobantesToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.comprobado;
            comprobantesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            comprobantesToolStripMenuItem.Margin = new Padding(0, 5, -3, 0);
            comprobantesToolStripMenuItem.MergeIndex = 50;
            comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            comprobantesToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            comprobantesToolStripMenuItem.Size = new Size(202, 49);
            comprobantesToolStripMenuItem.Text = "Comprobantes";
            // 
            // boletasToolStripMenuItem
            // 
            boletasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.proyecto_de_ley1;
            boletasToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            boletasToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            boletasToolStripMenuItem.Size = new Size(180, 37);
            boletasToolStripMenuItem.Text = "Boletas";
            boletasToolStripMenuItem.Click += boletasToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cuenta1;
            facturasToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            facturasToolStripMenuItem.Size = new Size(180, 37);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // salirDelSistemasToolStripMenuItem
            // 
            salirDelSistemasToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirDelSistemasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cerrar_sesion;
            salirDelSistemasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            salirDelSistemasToolStripMenuItem.Margin = new Padding(0, 5, -3, 0);
            salirDelSistemasToolStripMenuItem.MergeIndex = 50;
            salirDelSistemasToolStripMenuItem.Name = "salirDelSistemasToolStripMenuItem";
            salirDelSistemasToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            salirDelSistemasToolStripMenuItem.Size = new Size(202, 49);
            salirDelSistemasToolStripMenuItem.Text = "Salir";
            salirDelSistemasToolStripMenuItem.Click += salirDelSistemasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(199, 4);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(200, 553);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(924, 35);
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logoToolStripMenuItem;
    }
}