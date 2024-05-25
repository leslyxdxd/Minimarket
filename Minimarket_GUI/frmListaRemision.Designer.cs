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
            dtgRemision = new DataGridView();
            btnGenerar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnCerrar = new Button();
            Id_Remision = new DataGridViewTextBoxColumn();
            Id_Proveedor = new DataGridViewTextBoxColumn();
            Nom_Proveedor = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nom_Producto = new DataGridViewTextBoxColumn();
            Id_Cat = new DataGridViewTextBoxColumn();
            FechaIni = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Des_Cat = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgRemision).BeginInit();
            SuspendLayout();
            // 
            // dtgRemision
            // 
            dtgRemision.AllowUserToAddRows = false;
            dtgRemision.AllowUserToDeleteRows = false;
            dtgRemision.Anchor = AnchorStyles.Left;
            dtgRemision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRemision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRemision.Columns.AddRange(new DataGridViewColumn[] { Id_Remision, Id_Proveedor, Nom_Proveedor, RUC, Telefono, Correo, Id_Producto, Nom_Producto, Id_Cat, FechaIni, FechaFin, Des_Cat, Cantidad, PrecioUnitario, total, Observaciones, Estado });
            dtgRemision.Location = new Point(27, 79);
            dtgRemision.Margin = new Padding(4, 3, 4, 3);
            dtgRemision.Name = "dtgRemision";
            dtgRemision.ReadOnly = true;
            dtgRemision.RowHeadersVisible = false;
            dtgRemision.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgRemision.Size = new Size(837, 370);
            dtgRemision.TabIndex = 8;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(587, 477);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(147, 31);
            btnGenerar.TabIndex = 9;
            btnGenerar.Text = "Nueva Remision";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(102, 489);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 10;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 493);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Registros:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 12;
            label1.Text = "Ingrese filtro por Nombre:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(177, 32);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(134, 23);
            txtFiltro.TabIndex = 13;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(740, 476);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(124, 32);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Id_Remision
            // 
            Id_Remision.DataPropertyName = "Id_Remision";
            Id_Remision.HeaderText = "Codigo Remision";
            Id_Remision.Name = "Id_Remision";
            Id_Remision.ReadOnly = true;
            Id_Remision.Visible = false;
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
            // 
            // FechaFin
            // 
            FechaFin.DataPropertyName = "FechaFin";
            FechaFin.HeaderText = "Fecha Recepcion";
            FechaFin.Name = "FechaFin";
            FechaFin.ReadOnly = true;
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
            Cantidad.Visible = false;
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
            // frmListaRemision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 546);
            Controls.Add(btnCerrar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(btnGenerar);
            Controls.Add(dtgRemision);
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
        private Button btnGenerar;
        private Label lblRegistros;
        private Label label2;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn Id_Remision;
        private DataGridViewTextBoxColumn Id_Proveedor;
        private DataGridViewTextBoxColumn Nom_Proveedor;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn Nom_Producto;
        private DataGridViewTextBoxColumn Id_Cat;
        private DataGridViewTextBoxColumn FechaIni;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Des_Cat;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn Observaciones;
        private DataGridViewTextBoxColumn Estado;
    }
}