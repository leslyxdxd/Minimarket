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
            traspasoATiendaToolStripMenuItem = new ToolStripMenuItem();
            generarGuiaToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            gestionarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            gestionarVentaToolStripMenuItem = new ToolStripMenuItem();
            generarRemisionToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem, consultasToolStripMenuItem, generarGuiaToolStripMenuItem, gestionarUsuariosToolStripMenuItem, gestionarVentaToolStripMenuItem, generarRemisionToolStripMenuItem, salirDelSistemasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10);
            menuStrip1.Size = new Size(1059, 41);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendedoresToolStripMenuItem, productoToolStripMenuItem, proveedoresToolStripMenuItem1 });
            mantenimientosToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(113, 21);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // vendedoresToolStripMenuItem
            // 
            vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            vendedoresToolStripMenuItem.Size = new Size(150, 22);
            vendedoresToolStripMenuItem.Text = "Vendedores";
            vendedoresToolStripMenuItem.Click += vendedoresToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(150, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem1
            // 
            proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            proveedoresToolStripMenuItem1.Size = new Size(150, 22);
            proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasClienteToolStripMenuItem, traspasoATiendaToolStripMenuItem });
            consultasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(79, 21);
            consultasToolStripMenuItem.Text = "Productos";
            // 
            // facturasClienteToolStripMenuItem
            // 
            facturasClienteToolStripMenuItem.Name = "facturasClienteToolStripMenuItem";
            facturasClienteToolStripMenuItem.Size = new Size(183, 22);
            facturasClienteToolStripMenuItem.Text = "Stock ";
            facturasClienteToolStripMenuItem.Click += facturasClienteToolStripMenuItem_Click;
            // 
            // traspasoATiendaToolStripMenuItem
            // 
            traspasoATiendaToolStripMenuItem.Name = "traspasoATiendaToolStripMenuItem";
            traspasoATiendaToolStripMenuItem.Size = new Size(183, 22);
            traspasoATiendaToolStripMenuItem.Text = "Traspaso a Tienda";
            // 
            // generarGuiaToolStripMenuItem
            // 
            generarGuiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem });
            generarGuiaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            generarGuiaToolStripMenuItem.Name = "generarGuiaToolStripMenuItem";
            generarGuiaToolStripMenuItem.Size = new Size(94, 21);
            generarGuiaToolStripMenuItem.Text = "Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 22);
            proveedoresToolStripMenuItem.Text = "Lista Proveedor";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click_1;
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            gestionarUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, agregarUsuarioToolStripMenuItem });
            gestionarUsuariosToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.Size = new Size(131, 21);
            gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            gestionarUsuariosToolStripMenuItem.Click += gestionarUsuariosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(173, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            agregarUsuarioToolStripMenuItem.Size = new Size(173, 22);
            agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            agregarUsuarioToolStripMenuItem.Click += agregarUsuarioToolStripMenuItem_Click;
            // 
            // gestionarVentaToolStripMenuItem
            // 
            gestionarVentaToolStripMenuItem.Name = "gestionarVentaToolStripMenuItem";
            gestionarVentaToolStripMenuItem.Size = new Size(101, 21);
            gestionarVentaToolStripMenuItem.Text = "Gestionar Venta";
            gestionarVentaToolStripMenuItem.Click += gestionarVentaToolStripMenuItem_Click;
            // 
            // generarRemisionToolStripMenuItem
            // 
            generarRemisionToolStripMenuItem.Name = "generarRemisionToolStripMenuItem";
            generarRemisionToolStripMenuItem.Size = new Size(116, 21);
            generarRemisionToolStripMenuItem.Text = "Guias de Remision";
            generarRemisionToolStripMenuItem.Click += generarRemisionToolStripMenuItem_Click;
            // 
            // salirDelSistemasToolStripMenuItem
            // 
            salirDelSistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            salirDelSistemasToolStripMenuItem.Font = new Font("Segoe UI", 9.75F);
            salirDelSistemasToolStripMenuItem.Name = "salirDelSistemasToolStripMenuItem";
            salirDelSistemasToolStripMenuItem.Size = new Size(116, 21);
            salirDelSistemasToolStripMenuItem.Text = "Salir del Sistema";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(101, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
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
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem vendedoresToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem facturasClienteToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem salirDelSistemasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem1;
        private ToolStripMenuItem generarGuiaToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private ToolStripMenuItem gestionarVentaToolStripMenuItem;
        private ToolStripMenuItem generarRemisionToolStripMenuItem;
        private ToolStripMenuItem traspasoATiendaToolStripMenuItem;
    }
}