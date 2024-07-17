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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaMovimientos));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtgRemision = new DataGridView();
            Nom_Producto = new DataGridViewTextBoxColumn();
            Movimiento_Tienda = new DataGridViewTextBoxColumn();
            Des_UM = new DataGridViewTextBoxColumn();
            Fec_Registro = new DataGridViewTextBoxColumn();
            Usu_Registro = new DataGridViewTextBoxColumn();
            txtFiltro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblRegistros = new Label();
            btnCerrar = new Button();
            label3 = new Label();
            cboTiempoPeriodo = new ComboBox();
            label5 = new Label();
            guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            label21 = new Label();
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
            dtgRemision.Columns.AddRange(new DataGridViewColumn[] { Nom_Producto, Movimiento_Tienda, Des_UM, Fec_Registro, Usu_Registro });
            dtgRemision.Location = new Point(27, 157);
            dtgRemision.Margin = new Padding(4, 3, 4, 3);
            dtgRemision.Name = "dtgRemision";
            dtgRemision.ReadOnly = true;
            dtgRemision.RowHeadersVisible = false;
            dtgRemision.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgRemision.Size = new Size(1098, 463);
            dtgRemision.TabIndex = 9;
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
            // txtFiltro
            // 
            txtFiltro.Location = new Point(143, 106);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(153, 23);
            txtFiltro.TabIndex = 15;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 109);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 14;
            label1.Text = "Filtro / Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 673);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 17;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(103, 669);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(161, 22);
            lblRegistros.TabIndex = 16;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(975, 642);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 49);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 109);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 22;
            label3.Text = "Filtro / Tiempo:";
            // 
            // cboTiempoPeriodo
            // 
            cboTiempoPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiempoPeriodo.FormattingEnabled = true;
            cboTiempoPeriodo.Location = new Point(465, 106);
            cboTiempoPeriodo.Name = "cboTiempoPeriodo";
            cboTiempoPeriodo.Size = new Size(210, 23);
            cboTiempoPeriodo.TabIndex = 30;
            cboTiempoPeriodo.SelectedIndexChanged += cboTiempoPeriodo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(863, 50);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 52;
            label5.Text = "Generar Reporte";
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
            guna2ImageButton3.Location = new Point(1050, 44);
            guna2ImageButton3.Name = "guna2ImageButton3";
            guna2ImageButton3.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton3.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton3.Size = new Size(59, 47);
            guna2ImageButton3.TabIndex = 51;
            guna2ImageButton3.Click += btnGenerar_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(27, 31);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(382, 32);
            label21.TabIndex = 53;
            label21.Text = "MOVIMIENTOS DE ALMACEN";
            // 
            // frmListaMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1157, 717);
            Controls.Add(label21);
            Controls.Add(label5);
            Controls.Add(guna2ImageButton3);
            Controls.Add(cboTiempoPeriodo);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(lblRegistros);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgRemision);
            FormBorderStyle = FormBorderStyle.None;
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
        private DataGridViewTextBoxColumn Nom_Producto;
        private DataGridViewTextBoxColumn Movimiento_Tienda;
        private DataGridViewTextBoxColumn Des_UM;
        private DataGridViewTextBoxColumn Fec_Registro;
        private DataGridViewTextBoxColumn Usu_Registro;
        private Label label3;
        private ComboBox cboTiempoPeriodo;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Label label21;
    }
}