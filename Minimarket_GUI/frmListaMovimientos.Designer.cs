namespace Minimarket_GUI
{
    partial class frmListaMovimientos
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
            txtFiltro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblRegistros = new Label();
            btnCerrar = new Button();
            btnGenerar = new Button();
            Nom_Producto = new DataGridViewTextBoxColumn();
            Movimiento_Tienda = new DataGridViewTextBoxColumn();
            Des_UM = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
            Usu_Registro = new DataGridViewTextBoxColumn();
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
            dtgRemision.Columns.AddRange(new DataGridViewColumn[] { Nom_Producto, Movimiento_Tienda, Des_UM, Fec_Registro, Usu_Registro });
            dtgRemision.Location = new Point(27, 81);
            dtgRemision.Margin = new Padding(4, 3, 4, 3);
            dtgRemision.Name = "dtgRemision";
            dtgRemision.ReadOnly = true;
            dtgRemision.RowHeadersVisible = false;
            dtgRemision.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgRemision.Size = new Size(869, 377);
            dtgRemision.TabIndex = 9;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(177, 29);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(134, 23);
            txtFiltro.TabIndex = 15;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 14;
            label1.Text = "Ingrese filtro por Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 486);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 17;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(91, 482);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(78, 22);
            lblRegistros.TabIndex = 16;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(772, 477);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(124, 32);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(624, 477);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(124, 32);
            btnGenerar.TabIndex = 19;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Nom_Producto
            // 
            Nom_Producto.DataPropertyName = "Nom_Producto";
            Nom_Producto.HeaderText = "Producto";
            Nom_Producto.Name = "Nom_Producto";
            Nom_Producto.ReadOnly = true;
            // 
            // Movimiento_Tienda
            // 
            Movimiento_Tienda.DataPropertyName = "Movimiento_Tienda";
            Movimiento_Tienda.HeaderText = "Cantidad Transferida";
            Movimiento_Tienda.Name = "Movimiento_Tienda";
            Movimiento_Tienda.ReadOnly = true;
            // 
            // Des_UM
            // 
            Des_UM.DataPropertyName = "Des_UM";
            Des_UM.HeaderText = "U.M.";
            Des_UM.Name = "Des_UM";
            Des_UM.ReadOnly = true;
            // 
            // Fec_Registro
            // 
            Fec_Registro.DataPropertyName = "Fec_Registro";
            Fec_Registro.HeaderText = "Fecha Transferida";
            Fec_Registro.Name = "Fec_Registro";
            Fec_Registro.ReadOnly = true;
            // 
            // Usu_Registro
            // 
            Usu_Registro.DataPropertyName = "Usu_Registro";
            Usu_Registro.HeaderText = "Usuario del Registro";
            Usu_Registro.Name = "Usu_Registro";
            Usu_Registro.ReadOnly = true;
            // 
            // frmListaMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 532);
            Controls.Add(btnGenerar);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgRemision);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaMovimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimientos";
            Load += frmListaMovimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRemision).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgRemision;
        private TextBox txtFiltro;
        private Label label1;
        private Label label2;
        private Label lblRegistros;
        private Button btnCerrar;
        private Button btnGenerar;
        private DataGridViewTextBoxColumn Nom_Producto;
        private DataGridViewTextBoxColumn Movimiento_Tienda;
        private DataGridViewTextBoxColumn Des_UM;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn Usu_Registro;
    }
}