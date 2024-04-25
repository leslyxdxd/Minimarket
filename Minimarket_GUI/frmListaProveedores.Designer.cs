namespace Minimarket_GUI
{
    partial class frmListaProveedores
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
            dtgDatos = new DataGridView();
            btnCerrar = new Button();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            btnGuia = new Button();
            Id_Proveedor = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AllowUserToResizeColumns = false;
            dtgDatos.AllowUserToResizeRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.BackgroundColor = SystemColors.ActiveBorder;
            dtgDatos.ColumnHeadersHeight = 50;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Id_Proveedor, Nombre, Direccion, Telefono, Correo, RUC, Estado });
            dtgDatos.Location = new Point(39, 87);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1078, 452);
            dtgDatos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(993, 589);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(124, 41);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 50);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por apellidos:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(212, 47);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(297, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 608);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(103, 608);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnGuia
            // 
            btnGuia.Location = new Point(977, 44);
            btnGuia.Name = "btnGuia";
            btnGuia.Size = new Size(140, 24);
            btnGuia.TabIndex = 4;
            btnGuia.Text = "Nueva Guia";
            btnGuia.UseVisualStyleBackColor = true;
            btnGuia.Click += btnGuia_Click;
            // 
            // Id_Proveedor
            // 
            Id_Proveedor.DataPropertyName = "Id_Proveedor";
            Id_Proveedor.HeaderText = "Cod Proveedor";
            Id_Proveedor.Name = "Id_Proveedor";
            Id_Proveedor.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nom_Proveedor";
            Nombre.HeaderText = "Nombre Proveedor";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direc_Proveedor";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono ";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "CorreoElectronico";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // RUC
            // 
            RUC.DataPropertyName = "RUC";
            RUC.HeaderText = "RUC";
            RUC.Name = "RUC";
            RUC.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // frmListaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1200, 661);
            Controls.Add(btnGuia);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Proveedores";
            Load += frmListaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private Button btnGuia;
        private DataGridViewTextBoxColumn Id_Proveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Estado;
    }
}