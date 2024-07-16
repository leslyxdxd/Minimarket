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
            toolStripMenuItem1 = new ToolStripMenuItem();
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
            menuStrip1.BackColor = Color.FromArgb(255, 224, 192);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, consultasToolStripMenuItem, generarGuiaToolStripMenuItem, gestionarUsuariosToolStripMenuItem, gestionarVentaToolStripMenuItem, generarRemisionToolStripMenuItem, comprobantesToolStripMenuItem, salirDelSistemasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(203, 692);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.White;
            toolStripMenuItem1.BackgroundImage = Minimarket_GUI.Properties.Resources._3565075;
            toolStripMenuItem1.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Padding = new Padding(4, 100, 4, 50);
            toolStripMenuItem1.Size = new Size(202, 154);
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            consultasToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StokTienda, stokAlmacen });
            consultasToolStripMenuItem.Font = new Font("Segoe UI", 11.25F);
            consultasToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            consultasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.paquete_o_empaquetar;
            consultasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            consultasToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            consultasToolStripMenuItem.MergeIndex = 50;
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            consultasToolStripMenuItem.Size = new Size(205, 49);
            consultasToolStripMenuItem.Text = "Productos";
            // 
            // StokTienda
            // 
            StokTienda.Image = Minimarket_GUI.Properties.Resources.monitor;
            StokTienda.Margin = new Padding(0, 10, 0, 0);
            StokTienda.Name = "StokTienda";
            StokTienda.Padding = new Padding(0, 5, 0, 10);
            StokTienda.Size = new Size(118, 37);
            StokTienda.Text = "Stock ";
            StokTienda.Click += facturasClienteToolStripMenuItem_Click;
            // 
            // stokAlmacen
            // 
            stokAlmacen.Image = Minimarket_GUI.Properties.Resources.almacen;
            stokAlmacen.Margin = new Padding(0, 10, 0, 0);
            stokAlmacen.Name = "stokAlmacen";
            stokAlmacen.Padding = new Padding(0, 5, 0, 10);
            stokAlmacen.Size = new Size(118, 37);
            stokAlmacen.Text = "Stock";
            stokAlmacen.Click += stokAlmacen_Click;
            // 
            // generarGuiaToolStripMenuItem
            // 
            generarGuiaToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            generarGuiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem });
            generarGuiaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F);
            generarGuiaToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            generarGuiaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.mensajero;
            generarGuiaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            generarGuiaToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            generarGuiaToolStripMenuItem.MergeIndex = 50;
            generarGuiaToolStripMenuItem.Name = "generarGuiaToolStripMenuItem";
            generarGuiaToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            generarGuiaToolStripMenuItem.Size = new Size(205, 49);
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
            gestionarUsuariosToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            gestionarUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, agregarUsuarioToolStripMenuItem });
            gestionarUsuariosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F);
            gestionarUsuariosToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            gestionarUsuariosToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.agregar_usuario;
            gestionarUsuariosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            gestionarUsuariosToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            gestionarUsuariosToolStripMenuItem.MergeIndex = 50;
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            gestionarUsuariosToolStripMenuItem.Size = new Size(205, 49);
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
            gestionarVentaToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            gestionarVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boletaToolStripMenuItem, facturaToolStripMenuItem });
            gestionarVentaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F);
            gestionarVentaToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            gestionarVentaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.punto_de_venta;
            gestionarVentaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            gestionarVentaToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            gestionarVentaToolStripMenuItem.MergeIndex = 50;
            gestionarVentaToolStripMenuItem.Name = "gestionarVentaToolStripMenuItem";
            gestionarVentaToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            gestionarVentaToolStripMenuItem.Size = new Size(205, 49);
            gestionarVentaToolStripMenuItem.Text = "Gestionar Venta";
            gestionarVentaToolStripMenuItem.Click += gestionarVentaToolStripMenuItem_Click;
            // 
            // boletaToolStripMenuItem
            // 
            boletaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.proyecto_de_ley;
            boletaToolStripMenuItem.Margin = new Padding(0, 10, 0, 0);
            boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
            boletaToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            boletaToolStripMenuItem.Size = new Size(125, 37);
            boletaToolStripMenuItem.Text = "Boleta";
            boletaToolStripMenuItem.Click += boletaToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cuenta;
            facturaToolStripMenuItem.Margin = new Padding(0, 10, 0, 0);
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            facturaToolStripMenuItem.Size = new Size(125, 37);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // generarRemisionToolStripMenuItem
            // 
            generarRemisionToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            generarRemisionToolStripMenuItem.Font = new Font("Segoe UI", 11.25F);
            generarRemisionToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            generarRemisionToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.contrato;
            generarRemisionToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            generarRemisionToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            generarRemisionToolStripMenuItem.MergeIndex = 50;
            generarRemisionToolStripMenuItem.Name = "generarRemisionToolStripMenuItem";
            generarRemisionToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            generarRemisionToolStripMenuItem.Size = new Size(205, 49);
            generarRemisionToolStripMenuItem.Text = "Guias de Remision";
            generarRemisionToolStripMenuItem.Click += generarRemisionToolStripMenuItem_Click;
            // 
            // comprobantesToolStripMenuItem
            // 
            comprobantesToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            comprobantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boletasToolStripMenuItem, facturasToolStripMenuItem });
            comprobantesToolStripMenuItem.Font = new Font("Segoe UI", 11.25F);
            comprobantesToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            comprobantesToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.comprobado;
            comprobantesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            comprobantesToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            comprobantesToolStripMenuItem.MergeIndex = 50;
            comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            comprobantesToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            comprobantesToolStripMenuItem.Size = new Size(205, 49);
            comprobantesToolStripMenuItem.Text = "Comprobantes";
            // 
            // boletasToolStripMenuItem
            // 
            boletasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.proyecto_de_ley1;
            boletasToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            boletasToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            boletasToolStripMenuItem.Size = new Size(131, 37);
            boletasToolStripMenuItem.Text = "Boletas";
            boletasToolStripMenuItem.Click += boletasToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cuenta1;
            facturasToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Padding = new Padding(0, 10, 0, 5);
            facturasToolStripMenuItem.Size = new Size(131, 37);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // salirDelSistemasToolStripMenuItem
            // 
            salirDelSistemasToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            salirDelSistemasToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirDelSistemasToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            salirDelSistemasToolStripMenuItem.Image = Minimarket_GUI.Properties.Resources.cerrar_sesion;
            salirDelSistemasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            salirDelSistemasToolStripMenuItem.Margin = new Padding(0, 1, -3, 1);
            salirDelSistemasToolStripMenuItem.MergeIndex = 50;
            salirDelSistemasToolStripMenuItem.Name = "salirDelSistemasToolStripMenuItem";
            salirDelSistemasToolStripMenuItem.Padding = new Padding(10, 10, 25, 15);
            salirDelSistemasToolStripMenuItem.Size = new Size(205, 50);
            salirDelSistemasToolStripMenuItem.Text = "Salir";
            salirDelSistemasToolStripMenuItem.Click += salirDelSistemasToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(203, 657);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1082, 35);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1285, 692);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
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
        private ToolStripMenuItem logoToolStripMenuItem;
        private ToolStripMenuItem fRESHSUPERMARKETToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}