namespace Minimarket_GUI
{
    partial class frmListaRemision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaRemision));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtgRemision = new DataGridView();
            Id_Remision = new DataGridViewTextBoxColumn();
            Num_Guia = new DataGridViewTextBoxColumn();
            Id_Proveedor = new DataGridViewTextBoxColumn();
            Nom_Proveedor = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nom_Producto = new DataGridViewTextBoxColumn();
            Id_Cat = new DataGridViewTextBoxColumn();
            FechaIni = new DataGridViewTextBoxColumn();
            Des_Cat = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Des_UM = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Fec_Ult_Mod = new DataGridViewTextBoxColumn();
            Usu_Ult_Mod = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnCerrar = new Button();
            btnActualizar = new Button();
            cboPro = new ComboBox();
            label3 = new Label();
            btnFiltrar = new Button();
            label4 = new Label();
            cboCantidad = new ComboBox();
            label21 = new Label();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgRemision).BeginInit();
            SuspendLayout();
            // 
            // dtgRemision
            // 
            dtgRemision.AllowUserToAddRows = false;
            dtgRemision.AllowUserToDeleteRows = false;
            dtgRemision.Anchor = AnchorStyles.Left;
            dtgRemision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRemision.BackgroundColor = SystemColors.ControlLight;
            dtgRemision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRemision.Columns.AddRange(new DataGridViewColumn[] { Id_Remision, Num_Guia, Id_Proveedor, Nom_Proveedor, RUC, Telefono, Correo, Id_Producto, Nom_Producto, Id_Cat, FechaIni, Des_Cat, Cantidad, Des_UM, PrecioUnitario, total, Observaciones, Estado, Fec_Registro, FechaFin, Fec_Ult_Mod, Usu_Ult_Mod });
            dtgRemision.Location = new Point(27, 193);
            dtgRemision.Margin = new Padding(4, 3, 4, 3);
            dtgRemision.Name = "dtgRemision";
            dtgRemision.ReadOnly = true;
            dtgRemision.RowHeadersVisible = false;
            dtgRemision.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgRemision.Size = new Size(1092, 428);
            dtgRemision.TabIndex = 8;
            dtgRemision.CellDoubleClick += dtgRemision_CellDoubleClick;
            // 
            // Id_Remision
            // 
            Id_Remision.DataPropertyName = "Id_Remision";
            Id_Remision.HeaderText = "Codigo Remision";
            Id_Remision.Name = "Id_Remision";
            Id_Remision.ReadOnly = true;
            Id_Remision.Visible = false;
            // 
            // Num_Guia
            // 
            Num_Guia.DataPropertyName = "Num_Guia";
            Num_Guia.HeaderText = "Nº Guia";
            Num_Guia.Name = "Num_Guia";
            Num_Guia.ReadOnly = true;
            // 
            // Id_Proveedor
            // 
            Id_Proveedor.DataPropertyName = "Id_Proveedor";
            Id_Proveedor.HeaderText = "Id_Proveedor";
            Id_Proveedor.Name = "Id_Proveedor";
            Id_Proveedor.ReadOnly = true;
            Id_Proveedor.Visible = false;
            // 
            // Nom_Proveedor
            // 
            Nom_Proveedor.DataPropertyName = "Nom_Proveedor";
            Nom_Proveedor.HeaderText = "Proveedor";
            Nom_Proveedor.Name = "Nom_Proveedor";
            Nom_Proveedor.ReadOnly = true;
            // 
            // RUC
            // 
            RUC.DataPropertyName = "RUC";
            RUC.HeaderText = "RUC";
            RUC.Name = "RUC";
            RUC.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Visible = false;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Visible = false;
            // 
            // Id_Producto
            // 
            Id_Producto.DataPropertyName = "Id_Producto";
            Id_Producto.HeaderText = "Id_Producto";
            Id_Producto.Name = "Id_Producto";
            Id_Producto.ReadOnly = true;
            Id_Producto.Visible = false;
            // 
            // Nom_Producto
            // 
            Nom_Producto.DataPropertyName = "Nom_Producto";
            Nom_Producto.HeaderText = "Producto";
            Nom_Producto.Name = "Nom_Producto";
            Nom_Producto.ReadOnly = true;
            // 
            // Id_Cat
            // 
            Id_Cat.DataPropertyName = "Id_Cat";
            Id_Cat.HeaderText = "Id_Cat";
            Id_Cat.Name = "Id_Cat";
            Id_Cat.ReadOnly = true;
            Id_Cat.Visible = false;
            // 
            // FechaIni
            // 
            FechaIni.DataPropertyName = "FechaIni";
            FechaIni.HeaderText = "Fecha Ingreso";
            FechaIni.Name = "FechaIni";
            FechaIni.ReadOnly = true;
            FechaIni.Visible = false;
            // 
            // Des_Cat
            // 
            Des_Cat.DataPropertyName = "Des_Cat";
            Des_Cat.HeaderText = "Categoria";
            Des_Cat.Name = "Des_Cat";
            Des_Cat.ReadOnly = true;
            Des_Cat.Visible = false;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Des_UM
            // 
            Des_UM.DataPropertyName = "Des_UM_Producto";
            Des_UM.HeaderText = "U.M.";
            Des_UM.Name = "Des_UM";
            Des_UM.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.DataPropertyName = "PrecioUnitario";
            PrecioUnitario.HeaderText = "Precio U. (Compra)";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            PrecioUnitario.Visible = false;
            // 
            // total
            // 
            total.DataPropertyName = "total";
            total.HeaderText = "Precio Total(S/.)";
            total.Name = "total";
            total.ReadOnly = true;
            total.Visible = false;
            // 
            // Observaciones
            // 
            Observaciones.DataPropertyName = "Observaciones";
            Observaciones.HeaderText = "Observaciones";
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            Observaciones.Visible = false;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Visible = false;
            // 
            // Fec_Registro
            // 
            Fec_Registro.DataPropertyName = "Fec_Registro";
            Fec_Registro.HeaderText = "Fecha de Registro";
            Fec_Registro.Name = "Fec_Registro";
            Fec_Registro.ReadOnly = true;
            Fec_Registro.Visible = false;
            // 
            // FechaFin
            // 
            FechaFin.DataPropertyName = "FechaFin";
            FechaFin.HeaderText = "Fecha Recepcion";
            FechaFin.Name = "FechaFin";
            FechaFin.ReadOnly = true;
            // 
            // Fec_Ult_Mod
            // 
            Fec_Ult_Mod.DataPropertyName = "Fec_Ult_Mod";
            Fec_Ult_Mod.HeaderText = "Fec_Ult_Mod";
            Fec_Ult_Mod.Name = "Fec_Ult_Mod";
            Fec_Ult_Mod.ReadOnly = true;
            Fec_Ult_Mod.Visible = false;
            // 
            // Usu_Ult_Mod
            // 
            Usu_Ult_Mod.DataPropertyName = "Usu_Ult_Mod";
            Usu_Ult_Mod.HeaderText = "Usu_Ult_Mod";
            Usu_Ult_Mod.Name = "Usu_Ult_Mod";
            Usu_Ult_Mod.ReadOnly = true;
            Usu_Ult_Mod.Visible = false;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(118, 658);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 10;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 662);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Registros:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 124);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 12;
            label1.Text = "Buscar / Nombre:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(166, 121);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(134, 23);
            txtFiltro.TabIndex = 13;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(966, 639);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(153, 52);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(745, 639);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(183, 52);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar Remision";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cboPro
            // 
            cboPro.BackColor = SystemColors.Window;
            cboPro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPro.ForeColor = SystemColors.InactiveCaptionText;
            cboPro.FormattingEnabled = true;
            cboPro.Location = new Point(456, 124);
            cboPro.Name = "cboPro";
            cboPro.Size = new Size(178, 23);
            cboPro.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 127);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 34;
            label3.Text = "Filtro / Proveedor:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(987, 119);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(132, 31);
            btnFiltrar.TabIndex = 35;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(666, 129);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 36;
            label4.Text = "Filtro / Cantidad";
            // 
            // cboCantidad
            // 
            cboCantidad.BackColor = SystemColors.Window;
            cboCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCantidad.ForeColor = SystemColors.InactiveCaptionText;
            cboCantidad.FormattingEnabled = true;
            cboCantidad.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "100", "200" });
            cboCantidad.Location = new Point(800, 124);
            cboCantidad.Name = "cboCantidad";
            cboCantidad.Size = new Size(141, 23);
            cboCantidad.TabIndex = 37;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(27, 42);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(273, 32);
            label21.TabIndex = 48;
            label21.Text = "GUIAS DE REMISIÓN";
            // 
            // guna2ImageButton3
            // 
            guna2ImageButton3.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Cursor = Cursors.Hand;
            guna2ImageButton3.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton3.Image = (Image)resources.GetObject("guna2ImageButton3.Image");
            guna2ImageButton3.ImageOffset = new Point(0, 0);
            guna2ImageButton3.ImageRotate = 0F;
            guna2ImageButton3.ImageSize = new Size(37, 37);
            guna2ImageButton3.Location = new Point(1060, 27);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton3.Size = new Size(59, 47);
            guna2ImageButton3.TabIndex = 49;
            guna2ImageButton3.Click += btnReporte_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(883, 42);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 50;
            label5.Text = "Generar Reporte";
            // 
            // frmListaRemision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1157, 717);
            Controls.Add(label5);
            Controls.Add(guna2ImageButton3);
            Controls.Add(label21);
            Controls.Add(cboCantidad);
            Controls.Add(label4);
            Controls.Add(btnFiltrar);
            Controls.Add(label3);
            Controls.Add(cboPro);
            Controls.Add(btnCerrar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(btnActualizar);
            Controls.Add(dtgRemision);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaRemision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guias de Remision";
            Load += frmListaRemision_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRemision).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgRemision;
        private Label lblRegistros;
        private Label label2;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnCerrar;
        private Button btnActualizar;
        private ComboBox cboPro;
        private Label label3;
        private Button btnFiltrar;
        private Label label4;
        private ComboBox cboCantidad;
        private DataGridViewTextBoxColumn Id_Remision;
        private DataGridViewTextBoxColumn Num_Guia;
        private DataGridViewTextBoxColumn Id_Proveedor;
        private DataGridViewTextBoxColumn Nom_Proveedor;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn Nom_Producto;
        private DataGridViewTextBoxColumn Id_Cat;
        private DataGridViewTextBoxColumn FechaIni;
        private DataGridViewTextBoxColumn Des_Cat;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Des_UM;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Fec_Ult_Mod;
        private DataGridViewTextBoxColumn Usu_Ult_Mod;
        private Label label21;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Label label5;
    }
}