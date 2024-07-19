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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dtgDatos = new DataGridView();
            Id_Proveedor = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Estado_Proveedor = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtFiltro = new TextBox();
            label2 = new Label();
            lblRegistros = new Label();
            label21 = new Label();
            btnInsertar = new Button();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            button2 = new Button();
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
            dtgDatos.BackgroundColor = SystemColors.ControlLight;
            dtgDatos.BorderStyle = BorderStyle.Fixed3D;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Id_Proveedor, Nombre, Direccion, Telefono, Correo, RUC, Estado, Estado_Proveedor });
            dtgDatos.Location = new Point(33, 141);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1089, 479);
            dtgDatos.TabIndex = 0;
        
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
            Direccion.Visible = false;
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
            Correo.Visible = false;
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
            Estado.Visible = false;
            // 
            // Estado_Proveedor
            // 
            Estado_Proveedor.DataPropertyName = "Estado_Proveedor";
            Estado_Proveedor.HeaderText = "Estado";
            Estado_Proveedor.Name = "Estado_Proveedor";
            Estado_Proveedor.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 91);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Filtro / RUC:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(156, 88);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(281, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 668);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Proveedores:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(156, 664);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(107, 22);
            lblRegistros.TabIndex = 2;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(33, 31);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(201, 32);
            label21.TabIndex = 49;
            label21.Text = "PROVEEDORES";
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.Teal;
            btnInsertar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(749, 648);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(203, 45);
            btnInsertar.TabIndex = 52;
            btnInsertar.Text = "Actualizar Proveedor";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(979, 648);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 45);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCerrar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.SteelBlue;
            btnFiltrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(938, 68);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(184, 43);
            btnFiltrar.TabIndex = 54;
            btnFiltrar.Text = "Consultar Proveedor";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(463, 648);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(247, 44);
            button2.TabIndex = 68;
            button2.Text = "Añadir Producto / Proveedor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmListaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1157, 717);
            Controls.Add(button2);
            Controls.Add(btnFiltrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
            Controls.Add(label21);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Id_Proveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Estado_Proveedor;
        private Label label21;
        private Button btnInsertar;
        internal Button btnCancelar;
        private Button btnFiltrar;
        private Button button2;
    }
}