namespace ProyVentas_GUI
{
    partial class frmGuiaRemision
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label3 = new Label();
            dtpFecIni = new DateTimePicker();
            dtpFecFin = new DateTimePicker();
            lblRegistros = new Label();
            label4 = new Label();
            dtgFacturas = new DataGridView();
            Id_Remision = new DataGridViewTextBoxColumn();
            FechaIni = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Id_Proveedor = new DataGridViewTextBoxColumn();
            Nom_Proveedor = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nom_Producto = new DataGridViewTextBoxColumn();
            Id_Cat = new DataGridViewTextBoxColumn();
            Des_Cat = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label5 = new Label();
            lblNombre = new Label();
            label6 = new Label();
            lblRuc = new Label();
            label8 = new Label();
            lblDireccion = new Label();
            label10 = new Label();
            lblTel = new Label();
            label12 = new Label();
            lblCorreo = new Label();
            label14 = new Label();
            lblEstados = new Label();
            lblCodigo = new Label();
            label1 = new Label();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 212);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Fin:";
            // 
            // dtpFecIni
            // 
            dtpFecIni.Format = DateTimePickerFormat.Short;
            dtpFecIni.Location = new Point(134, 210);
            dtpFecIni.Margin = new Padding(4, 3, 4, 3);
            dtpFecIni.Name = "dtpFecIni";
            dtpFecIni.Size = new Size(192, 23);
            dtpFecIni.TabIndex = 3;
            // 
            // dtpFecFin
            // 
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(462, 210);
            dtpFecFin.Margin = new Padding(4, 3, 4, 3);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(182, 23);
            dtpFecFin.TabIndex = 5;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(101, 639);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(153, 26);
            lblRegistros.TabIndex = 9;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 643);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 8;
            label4.Text = "Registros:";
            // 
            // dtgFacturas
            // 
            dtgFacturas.AllowUserToAddRows = false;
            dtgFacturas.AllowUserToDeleteRows = false;
            dtgFacturas.AllowUserToResizeColumns = false;
            dtgFacturas.AllowUserToResizeRows = false;
            dtgFacturas.Anchor = AnchorStyles.Left;
            dtgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFacturas.BackgroundColor = SystemColors.ControlLight;
            dtgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgFacturas.Columns.AddRange(new DataGridViewColumn[] { Id_Remision, FechaIni, FechaFin, Id_Proveedor, Nom_Proveedor, RUC, Telefono, Correo, Id_Producto, Nom_Producto, Id_Cat, Des_Cat, Cantidad, Observaciones, Estado });
            dtgFacturas.Location = new Point(27, 256);
            dtgFacturas.Margin = new Padding(4, 3, 4, 3);
            dtgFacturas.Name = "dtgFacturas";
            dtgFacturas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgFacturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFacturas.Size = new Size(922, 369);
            dtgFacturas.TabIndex = 7;
            // 
            // Id_Remision
            // 
            Id_Remision.DataPropertyName = "Id_Remision";
            Id_Remision.HeaderText = "Codigo Remision";
            Id_Remision.Name = "Id_Remision";
            Id_Remision.ReadOnly = true;
            // 
            // FechaIni
            // 
            FechaIni.DataPropertyName = "FechaIni";
            FechaIni.HeaderText = "Fec.Inicio";
            FechaIni.Name = "FechaIni";
            FechaIni.ReadOnly = true;
            // 
            // FechaFin
            // 
            FechaFin.DataPropertyName = "FechaFin";
            FechaFin.HeaderText = "Fec.Fin";
            FechaFin.Name = "FechaFin";
            FechaFin.ReadOnly = true;
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
            Nom_Proveedor.Visible = false;
            // 
            // RUC
            // 
            RUC.DataPropertyName = "RUC";
            RUC.HeaderText = "RUC";
            RUC.Name = "RUC";
            RUC.ReadOnly = true;
            RUC.Visible = false;
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
            Cantidad.HeaderText = "Cantidad ingresada";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 11;
            label5.Text = "Razon social:";
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Location = new Point(307, 35);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(534, 26);
            lblNombre.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 80);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 11;
            label6.Text = "RUC:";
            // 
            // lblRuc
            // 
            lblRuc.BorderStyle = BorderStyle.FixedSingle;
            lblRuc.Location = new Point(85, 78);
            lblRuc.Margin = new Padding(4, 0, 4, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(116, 26);
            lblRuc.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(235, 80);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 11;
            label8.Text = "Direccion:";
            // 
            // lblDireccion
            // 
            lblDireccion.BorderStyle = BorderStyle.FixedSingle;
            lblDireccion.Location = new Point(307, 78);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(642, 26);
            lblDireccion.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 131);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 11;
            label10.Text = "Telefono:";
            // 
            // lblTel
            // 
            lblTel.BorderStyle = BorderStyle.FixedSingle;
            lblTel.Location = new Point(85, 124);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(116, 26);
            lblTel.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(249, 131);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 11;
            label12.Text = "Correo:";
            // 
            // lblCorreo
            // 
            lblCorreo.BorderStyle = BorderStyle.FixedSingle;
            lblCorreo.Location = new Point(307, 124);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(473, 26);
            lblCorreo.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(802, 131);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 11;
            label14.Text = "Estado:";
            // 
            // lblEstados
            // 
            lblEstados.BorderStyle = BorderStyle.FixedSingle;
            lblEstados.Location = new Point(855, 124);
            lblEstados.Margin = new Padding(4, 0, 4, 0);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(94, 26);
            lblEstados.TabIndex = 12;
            lblEstados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(88, 38);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(113, 23);
            lblCodigo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "Codigo";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.SteelBlue;
            btnFiltrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(802, 199);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(147, 39);
            btnFiltrar.TabIndex = 36;
            btnFiltrar.Text = "Consultar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnConsultar_Click;
            // 
            // frmGuiaRemision
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(984, 678);
            Controls.Add(btnFiltrar);
            Controls.Add(label1);
            Controls.Add(lblCodigo);
            Controls.Add(lblDireccion);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(lblCorreo);
            Controls.Add(label12);
            Controls.Add(lblEstados);
            Controls.Add(lblTel);
            Controls.Add(label10);
            Controls.Add(lblRuc);
            Controls.Add(label6);
            Controls.Add(lblNombre);
            Controls.Add(label5);
            Controls.Add(dtgFacturas);
            Controls.Add(lblRegistros);
            Controls.Add(label4);
            Controls.Add(dtpFecFin);
            Controls.Add(dtpFecIni);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 900);
            MinimizeBox = false;
            MinimumSize = new Size(907, 548);
            Name = "frmGuiaRemision";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Proveedor";
            Load += frmConsFacturasCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dtgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgFacturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEstados;
        private Label lblCodigo;
        private Label label1;
        private DataGridViewTextBoxColumn Id_Remision;
        private DataGridViewTextBoxColumn FechaIni;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Id_Proveedor;
        private DataGridViewTextBoxColumn Nom_Proveedor;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn Nom_Producto;
        private DataGridViewTextBoxColumn Id_Cat;
        private DataGridViewTextBoxColumn Des_Cat;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn Estado;
        private Button btnFiltrar;
    }
}