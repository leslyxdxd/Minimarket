namespace Minimarket_GUI
{
    partial class frmListaMinimarket
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
            dtgDatosMinimarket = new DataGridView();
            Id_Empresa = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Ruc = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            des_estado = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label2 = new Label();
            label21 = new Label();
            txtFiltro = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnInhabilitar = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatosMinimarket).BeginInit();
            SuspendLayout();
            // 
            // dtgDatosMinimarket
            // 
            dtgDatosMinimarket.AllowUserToAddRows = false;
            dtgDatosMinimarket.AllowUserToDeleteRows = false;
            dtgDatosMinimarket.AllowUserToResizeColumns = false;
            dtgDatosMinimarket.AllowUserToResizeRows = false;
            dtgDatosMinimarket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatosMinimarket.BackgroundColor = SystemColors.ControlLight;
            dtgDatosMinimarket.BorderStyle = BorderStyle.Fixed3D;
            dtgDatosMinimarket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosMinimarket.Columns.AddRange(new DataGridViewColumn[] { Id_Empresa, Nombre, Direccion, Ruc, estado, des_estado, Telefono });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgDatosMinimarket.DefaultCellStyle = dataGridViewCellStyle1;
            dtgDatosMinimarket.Location = new Point(26, 131);
            dtgDatosMinimarket.Name = "dtgDatosMinimarket";
            dtgDatosMinimarket.ReadOnly = true;
            dtgDatosMinimarket.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dtgDatosMinimarket.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgDatosMinimarket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatosMinimarket.Size = new Size(1091, 363);
            dtgDatosMinimarket.TabIndex = 2;
            dtgDatosMinimarket.CellContentClick += dtgDatosMinimarket_CellContentClick;
            // 
            // Id_Empresa
            // 
            Id_Empresa.DataPropertyName = "Id_Empresa";
            Id_Empresa.HeaderText = "Id_Empresa";
            Id_Empresa.Name = "Id_Empresa";
            Id_Empresa.ReadOnly = true;
            Id_Empresa.Visible = false;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Ruc
            // 
            Ruc.DataPropertyName = "Ruc";
            Ruc.HeaderText = "Ruc";
            Ruc.Name = "Ruc";
            Ruc.ReadOnly = true;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Visible = false;
            // 
            // des_estado
            // 
            des_estado.DataPropertyName = "des_estado";
            des_estado.HeaderText = "Estado";
            des_estado.Name = "des_estado";
            des_estado.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(124, 543);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 13;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 547);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 12;
            label2.Text = "Productos:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(26, 27);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(176, 32);
            label21.TabIndex = 55;
            label21.Text = "MINIMARKET";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(162, 87);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(239, 23);
            txtFiltro.TabIndex = 57;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 90);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 56;
            label1.Text = "Filtro / Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(966, 523);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 48);
            btnCancelar.TabIndex = 61;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCerrar_Click;
            // 
            // btnInhabilitar
            // 
            btnInhabilitar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInhabilitar.BackColor = Color.Firebrick;
            btnInhabilitar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInhabilitar.ForeColor = Color.White;
            btnInhabilitar.Location = new Point(757, 524);
            btnInhabilitar.Margin = new Padding(4, 3, 4, 3);
            btnInhabilitar.Name = "btnInhabilitar";
            btnInhabilitar.Size = new Size(156, 45);
            btnInhabilitar.TabIndex = 62;
            btnInhabilitar.Text = "Inhabilitar";
            btnInhabilitar.UseVisualStyleBackColor = false;
            btnInhabilitar.Click += btnInhabilitar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.SteelBlue;
            btnFiltrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(933, 53);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(184, 43);
            btnFiltrar.TabIndex = 63;
            btnFiltrar.Text = "Añadir Minimarket";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // frmListaMinimarket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 595);
            Controls.Add(btnFiltrar);
            Controls.Add(btnInhabilitar);
            Controls.Add(btnCancelar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(label21);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgDatosMinimarket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaMinimarket";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmListaMinimarket_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatosMinimarket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatosMinimarket;
        private Label lblRegistros;
        private Label label2;
        private Label label21;
        
        private TextBox txtFiltro;
        private Label label1;
        private DataGridViewTextBoxColumn Id_Empresa;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Ruc;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn des_estado;
        private DataGridViewTextBoxColumn Telefono;
        internal Button btnCancelar;
        private Button btnInhabilitar;
        private Button btnFiltrar;
    }
}